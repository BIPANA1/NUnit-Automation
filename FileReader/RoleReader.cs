using NUnit.Framework;

namespace nUnitTestProject.Utils
{
    public static class RoleDataReader
    {
         public static IEnumerable<TestCaseData> GetRoleData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\RoleData.csv");
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 2) continue;

                yield return new TestCaseData(
                    parts[0].Trim(),
                    parts[1].Trim() 
                ).SetName($"RoleTest_{parts[0]}");
            }
        }
    }
}