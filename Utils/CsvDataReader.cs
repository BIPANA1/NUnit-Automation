// using System;
// using System.Collections.Generic;
// using System.IO;
// using NUnit.Framework;

// namespace nUnitTestProject.Utils
// {
//     public static class CsvDataReader
//     {
//         public static IEnumerable<TestCaseData> GetLoginData()
//         {
//             string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
//              var lines = File.ReadAllLines(filePath);

//             // string filePath = Path.Combine(projectRoot, "Data", "LoginData.csv");

//             // var lines = File.ReadAllLines(filePath);
//             for (int i = 1; i < lines.Length; i++) // Skip header
//             {
//                 var parts = lines[i].Split(',');
//                 if (parts.Length < 3 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]) || string.IsNullOrWhiteSpace(parts[2]))
//                 {
//                     Console.WriteLine($" Skipping invalid line {i + 1}: '{lines[i]}'");
//                     continue;
//                 }

//                 yield return new TestCaseData(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
//             }
//         }
//     }
// }