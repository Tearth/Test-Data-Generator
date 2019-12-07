using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestDataGenerator.Models;

namespace TestDataGenerator
{
    public class Exporter
    {
        public bool Save(string outputPath, IEnumerable<Set> sets)
        {
            if (!Directory.Exists(outputPath))
            {
                return false;
            }

            foreach (var set in sets)
            {
                var fileName = $"{set.SetId}.txt";
                using (var fileStream = new StreamWriter(Path.Combine(outputPath, fileName)))
                {
                    fileStream.WriteLine(set.TasksCount);
                    fileStream.WriteLine(set.ProcessorsCount);

                    foreach (var task in set.Tasks)
                    {
                        fileStream.Write(task.TaskId);
                        fileStream.Write(" ");
                        fileStream.WriteLine(string.Join(' ', task.Times.Select(p => p.ToString())));
                    }
                }
            }

            return true;
        }
    }
}
