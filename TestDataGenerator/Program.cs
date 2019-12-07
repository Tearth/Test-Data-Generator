using System;
using CommandLine;

namespace TestDataGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data Generator");
            Console.WriteLine("===================");
            Console.WriteLine();

            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                Console.WriteLine($"Output path: {options.OutputPath}");
                Console.WriteLine($"Test sets count: {options.TestSetsCount}");
                Console.WriteLine($"Minimum tasks count: {options.MinTasksCount}");
                Console.WriteLine($"Maximum tasks count: {options.MaxTasksCount}");
                Console.WriteLine($"Minimum processors count: {options.MinProcessorsCount}");
                Console.WriteLine($"Maximum processors count: {options.MaxProcessorsCount}");
                Console.WriteLine($"Minimum task time: {options.MinTaskTime}");
                Console.WriteLine($"Maximum task time: {options.MaxTaskTime}");
            });

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.Read();
        }
    }
}