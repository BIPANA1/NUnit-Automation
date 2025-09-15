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

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                var parts = lines[i].Split(',');
                if (parts.Length < 7) continue;

                yield return new TestCaseData(
                    parts[0].Trim(), // firstname
                    parts[1].Trim(), // lastname
                    parts[2].Trim(), // email
                    parts[3].Trim(), // phonenumber
                    parts[4].Trim(), // password
                    parts[5].Trim(), // confirmpassword
                    parts[6].Trim()  // expectedResult
                ).SetName($"UserTest_{parts[2]}");
            }
        }
    }
}