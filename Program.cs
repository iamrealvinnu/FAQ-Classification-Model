using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace FAQClassification
{
    public class FAQ
    {
        [LoadColumn(0)]
        public string? Question { get; set; }

        [LoadColumn(1)]
        public string? Category { get; set; }
    }

    public static class TextPreprocessing
    {
        public static string PreprocessText(string? text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;

            text = text.ToLower();
            text = Regex.Replace(text, @"[^\w\s]", "");
            return text.Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mlContext = new MLContext();

            // Path to the dataset file
            string dataPath = @"D:\FAQGDI\faQ\faQClassification\faq_dataset.csv";

            // Load data from the file
            var dataView = mlContext.Data.LoadFromTextFile<FAQ>(
                path: dataPath,
                separatorChar: ',',
                hasHeader: true);

            // Preprocess and clean up data
            var faqData = mlContext.Data.CreateEnumerable<FAQ>(dataView, reuseRowObject: false);
            var processedFAQs = new List<FAQ>();

            foreach (var faq in faqData)
            {
                if (!string.IsNullOrWhiteSpace(faq.Question) && !string.IsNullOrWhiteSpace(faq.Category))
                {
                    processedFAQs.Add(new FAQ
                    {
                        Question = TextPreprocessing.PreprocessText(faq.Question),
                        Category = faq.Category
                    });
                }
            }

            var processedDataView = mlContext.Data.LoadFromEnumerable(processedFAQs);

            // Split data
            var splitData = mlContext.Data.TrainTestSplit(processedDataView, testFraction: 0.2);

            // Pipeline for data processing and training
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", "Category")
                .Append(mlContext.Transforms.Text.FeaturizeText("Features", "Question"))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(splitData.TrainSet);

            // Evaluate model
            var predictions = model.Transform(splitData.TestSet);
            var metrics = mlContext.MulticlassClassification.Evaluate(predictions);

            Console.WriteLine($"Macro Accuracy: {metrics.MacroAccuracy:F2}");
            Console.WriteLine($"Micro Accuracy: {metrics.MicroAccuracy:F2}");
            Console.WriteLine($"Log Loss: {metrics.LogLoss:F2}");

            // Display confusion table
            Console.WriteLine("\nPer-Class Log Loss:");
            for (int i = 0; i < metrics.PerClassLogLoss.Count; i++)
            {
                Console.WriteLine($"Class {i}: {metrics.PerClassLogLoss[i]:F2}");
            }

            Console.ReadLine();
        }
    }
}
