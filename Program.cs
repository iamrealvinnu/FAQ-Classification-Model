using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace faQClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create MLContext
                var context = new MLContext();

                // Load the data
                var dataPath = @"D:\FAQGDI\faQ\faQClassification\bin\Debug\net8.0\faq_dataset.csv";
                var data = context.Data.LoadFromTextFile<FAQ>(
                    dataPath,
                    separatorChar: ',',
                    hasHeader: true);

                // Split the data into training and test sets
                var trainTestSplit = context.Data.TrainTestSplit(data, testFraction: 0.2);

                // Define the training pipeline
                var pipeline = context.Transforms.Conversion.MapValueToKey("Label", "Category")
                    .Append(context.Transforms.Text.FeaturizeText("Features", "Question"))
                    .Append(context.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                    .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                // Train the model
                var model = pipeline.Fit(trainTestSplit.TrainSet);

                // Make predictions
                var predictions = model.Transform(trainTestSplit.TestSet);

                // Evaluate the model
                var metrics = context.MulticlassClassification.Evaluate(predictions);

                // Output the results
                Console.WriteLine($"Macro Accuracy: {metrics.MacroAccuracy}");
                Console.WriteLine($"Log-loss: {metrics.LogLoss}");
                Console.WriteLine($"Micro Accuracy: {metrics.MicroAccuracy}");

                // Display the confusion matrix
                Console.WriteLine("Confusion Matrix:");
                foreach (var row in metrics.ConfusionMatrix.Counts)
                {
                    foreach (var value in row)
                    {
                        Console.Write($"{value} ");
                    }
                    Console.WriteLine();
                }

                // Keep the console window open
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Class to define data schema
        public class FAQ
        {
            [LoadColumn(0)]
            public string Question { get; set; } = string.Empty;

            [LoadColumn(1)]
            public string Category { get; set; } = string.Empty;
        }
    }
}
