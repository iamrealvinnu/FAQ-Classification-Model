using Microsoft.ML.Data;

namespace faQClassification
{
    public class FAQ
    {
        [LoadColumn(0)]
        public required string Question { get; set; }

        [LoadColumn(1)]
        public required string Category { get; set; }
    }

    public class Prediction
    {
        [ColumnName("PredictedLabel")]
        public required string PredictedCategory { get; set; }
    }
}
