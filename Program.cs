using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace faQClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create MLContext
            var context = new MLContext();

            // Load the data
            var dataPath = @"D:\FAQGDI\faQ\faQClassification\bin\Debug\net8.0\faq_dataset.csv";
            var data = context.Data.LoadFromTextFile<FAQ>(dataPath, separatorChar: ',', hasHeader: true);

            // Split the data into training and test sets
            var trainTestSplit = context.Data.TrainTestSplit(data, testFraction: 0.2);

            // Define the training pipeline
            var pipeline = context.Transforms.Conversion.MapValueToKey("Label", "Category")
                .Append(context.Transforms.Text.FeaturizeText("Features", "Question"))
                .Append(context.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Train the model
            var model = pipeline.Fit(trainTestSplit.TrainSet);

            // Evaluate the model
            var predictions = model.Transform(trainTestSplit.TestSet);
            var metrics = context.MulticlassClassification.Evaluate(predictions);

            // Output
            Console.WriteLine($"Macro Accuracy: {metrics.MacroAccuracy}");
            Console.WriteLine($"Log-loss: {metrics.LogLoss}");
        }
    }
}