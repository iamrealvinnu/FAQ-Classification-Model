using System;
using System.Collections.Generic;

namespace faQClassification
{
    public static class DataAugmentation
    {
        // Method to generate variations of a question
        public static List<string> GenerateVariations(string question)
        {
            var variations = new List<string>
            {
                question, // Original question
                question.ToLower(), // Lowercase version
                question + "?", // Adding a question mark
                "Can you tell me " + question.ToLower(), // Adding a prefix
                "What about " + question.ToLower(), // Another variation
                "How do I " + question.ToLower(), // Another variation
                "Please explain " + question.ToLower() // Another variation
            };

            return variations;
        }
    }
}