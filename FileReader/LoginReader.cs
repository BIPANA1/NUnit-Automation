
using NUnit.Framework;

namespace nUnitTestProject.Utils
{
    public static class LoginDataReader
    {
        public static IEnumerable<TestCaseData> GetLoginData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\LoginData.csv");
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 3) continue;

                yield return new TestCaseData(
                    parts[0].Trim(), 
                    parts[1].Trim(), 
                    parts[2].Trim()  
                ).SetName($"LoginTest_{parts[0]}");
            }
        }
    }
}