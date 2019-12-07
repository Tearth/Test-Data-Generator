using System;
using CommandLine;
using TestDataGenerator.Models;

namespace TestDataGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var options = default(Options);
            var generator = new Generator();

            Console.WriteLine("Test Data Generator");
            Console.WriteLine("===================");
            Console.WriteLine();

            Parser.Default.ParseArguments<Options>(args).WithParsed(o =>
            {
                options = o;

                Console.WriteLine($"Output path: {o.OutputPath}");
                Console.WriteLine($"Test sets count: {o.TestSetsCount}");
                Console.WriteLine($"Minimum tasks count: {o.MinTasksCount}");
                Console.WriteLine($"Maximum tasks count: {o.MaxTasksCount}");
                Console.WriteLine($"Minimum processors count: {o.MinProcessorsCount}");
                Console.WriteLine($"Maximum processors count: {o.MaxProcessorsCount}");
                Console.WriteLine($"Minimum task time: {o.MinTaskTime}");
                Console.WriteLine($"Maximum task time: {o.MaxTaskTime}");
            });

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine();

            var generatedSets = generator.Generate(options);
            Console.Read();
        }
    }
}