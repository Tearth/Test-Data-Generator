using CommandLine;

namespace TestDataGenerator.Models
{
    public class Options
    {
        [Option("output", HelpText = "Set directory where output files will be saved.", Required = false, Default = "./output")]
        public string OutputPath { get; set; }

        [Option("count", HelpText = "Set number of the sets which will be generated.", Required = false, Default = 10)]
        public int TestSetsCount { get; set; }

        [Option("min-tasks", HelpText = "Set number of the minimum tasks in the set.", Required = false, Default = 1)]
        public int MinTasksCount { get; set; }

        [Option("max-tasks", HelpText = "Set number of the maximum tasks in the set.", Required = false, Default = 10)]
        public int MaxTasksCount { get; set; }

        [Option("min-cpu", HelpText = "Set number of the minimum processors in the set.", Required = false, Default = 1)]
        public int MinProcessorsCount { get; set; }

        [Option("max-cpu", HelpText = "Set number of the maximum processors in the set.", Required = false, Default = 4)]
        public int MaxProcessorsCount { get; set; }

        [Option("min-time", HelpText = "Set minimum time which will be assigned to the task.", Required = false, Default = 1)]
        public int MinTaskTime { get; set; }

        [Option("max-time", HelpText = "Set maximum time which will be assigned to the task.", Required = false, Default = 100)]
        public int MaxTaskTime { get; set; }
    }
}
