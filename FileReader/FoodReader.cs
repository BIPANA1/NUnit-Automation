using NUnit.Framework;

namespace nUnitTestProject.Utils
{
    public static class FoodDataReader
    {
         public static IEnumerable<TestCaseData> GetFoodData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\FoodData.csv");
            
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 4) continue;

                yield return new TestCaseData(
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim(),
                    parts[3].Trim()

                ).SetName($"FoodTest_{parts[0]}");
            }
        }
    }
}