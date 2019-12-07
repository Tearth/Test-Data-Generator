using System;
using System.Collections.Generic;
using TestDataGenerator.Models;

namespace TestDataGenerator
{
    public class Generator
    {
        private readonly Random _random;

        public Generator()
        {
            _random = new Random();
        }

        public IEnumerable<Set> Generate(Options options)
        {
            for (var i = 1; i <= options.TestSetsCount; i++)
            {
                var set = new Set
                {
                    SetId = i,
                    ProcessorsCount = _random.Next(options.MinProcessorsCount, options.MaxProcessorsCount + 1),
                    TasksCount = _random.Next(options.MinTasksCount, options.MaxTasksCount + 1)
                };
                set.Tasks = CreateListOfTasks(set.TasksCount, set.ProcessorsCount, options.MinTaskTime, options.MaxTaskTime);

                yield return set;
            }
        }

        private IEnumerable<Task> CreateListOfTasks(int count, int processorsCount, int minTaskTime, int maxTaskTime)
        {
            for (var i = 1; i <= count; i++)
            {
                yield return new Task
                {
                    TaskId = i,
                    Times = CreateListWithRandomValues(processorsCount, minTaskTime, maxTaskTime)
                };
            }
        }

        private IEnumerable<int> CreateListWithRandomValues(int count, int minValue, int maxValue)
        {
            for (var i = 0; i < count; i++)
            {
                yield return _random.Next(minValue, maxValue + 1);
            }
        }
    }
}
