using NUnit.Framework;

namespace nUnitTestProject.Utils
{
    public static class VehicleDataReader
    {
         public static IEnumerable<TestCaseData> GetVehicleData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\VehicleData.csv");
            
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) 
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 8) continue;

                yield return new TestCaseData(
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim(),
                    parts[3].Trim(),
                    parts[4].Trim(),
                    parts[5].Trim(),
                    parts[6].Trim(),
                    parts[7].Trim(),
                    parts[8].Trim()

                ).SetName($"VehicleTest_{parts[0]}");
            }
        }
    }
}