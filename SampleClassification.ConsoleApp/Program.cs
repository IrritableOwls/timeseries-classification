//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Col0 = 0F,
                Col1 = 10776.59F,
                Col2 = 10786.88F,
                Col3 = 10776.59F,
                Col4 = 10781.13F,
                Col5 = 71.83904F,
                Col6 = 774592.3F,
                Col7 = 1035F,
                Col8 = 35.352142F,
                Col9 = 381184.16F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col10 with predicted Col10 from sample data...\n\n");
            Console.WriteLine($"Col0: {sampleData.Col0}");
            Console.WriteLine($"Col1: {sampleData.Col1}");
            Console.WriteLine($"Col2: {sampleData.Col2}");
            Console.WriteLine($"Col3: {sampleData.Col3}");
            Console.WriteLine($"Col4: {sampleData.Col4}");
            Console.WriteLine($"Col5: {sampleData.Col5}");
            Console.WriteLine($"Col6: {sampleData.Col6}");
            Console.WriteLine($"Col7: {sampleData.Col7}");
            Console.WriteLine($"Col8: {sampleData.Col8}");
            Console.WriteLine($"Col9: {sampleData.Col9}");
            Console.WriteLine($"\n\nPredicted Col10 value {predictionResult.Prediction} \nPredicted Col10 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
