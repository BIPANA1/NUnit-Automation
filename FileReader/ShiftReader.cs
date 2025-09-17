using NUnit.Framework;

namespace nUnitTestProject.Utils
{
    public static class ShiftDataReader
    {
         public static IEnumerable<TestCaseData> GetShiftData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\ShiftData.csv");
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 2) continue;

                yield return new TestCaseData(
                    parts[0].Trim(),
                    parts[1].Trim()
                  
                ).SetName($"ShiftTest_{parts[0]}");
            }
        }
    }
}