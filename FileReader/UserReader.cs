using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace nUnitTestProject.FileReaders
{
    public static class UserDataReader
    {
        public static IEnumerable<TestCaseData> GetUserData()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\UserData.csv");
            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++) 
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 7) continue;

                yield return new TestCaseData(
                    parts[0].Trim(),
                    parts[1].Trim(), 
                    parts[2].Trim(), 
                    parts[3].Trim(),
                    parts[4].Trim(), 
                    parts[5].Trim(), 
                    parts[6].Trim()  
                ).SetName($"UserTest_{parts[2]}");
            }
        }
    }
}