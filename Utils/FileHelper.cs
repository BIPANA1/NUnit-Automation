// using System.Collections.Generic;
// using System.IO;

// namespace nUnitTestProject.Utils
// {
//     public static class FileHelper
//     {
//         public static IEnumerable<object[]> ReadCsv(string relativePath)
//         {
//             string basePath = AppDomain.CurrentDomain.BaseDirectory;
//             string fullPath = Path.Combine(basePath, relativePath);

//             if (!File.Exists(fullPath))
//                 throw new FileNotFoundException($"CSV file not found at: {fullPath}");

//             var lines = File.ReadAllLines(fullPath);
//             foreach (var line in lines.Skip(1)) // Skip header
//             {
//                 var values = line.Split(',');
//                 yield return new object[] { values[0], values[1], values[2] };
//             }
//         }
//     }
// }
