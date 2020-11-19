using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace School.xUnit
{
    public class CsvUserFeatures : DataAttribute
    {
        private readonly string _filePath;

        public CsvUserFeatures(string filePath)
        {
            _filePath = filePath;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var csvLines = File.ReadAllLines(_filePath);
            var csvData = new List<object[]>();
            foreach (var line in csvLines)
            {
                string[] values = line.Replace(" ", "").Replace("\\", "").Split(",");
                Guid userId = Guid.Parse(values[0]);
                string actionName = values[1];
                bool expectedValue = Boolean.Parse(values[2]);
                csvData.Add(new object[] { userId, actionName, expectedValue });
            }
            return csvData;
        }
    }

}
