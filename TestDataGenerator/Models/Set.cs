using System.Collections.Generic;

namespace TestDataGenerator.Models
{
    public class Set
    {
        public int SetId { get; set; }
        public int TasksCount { get; set; }
        public int ProcessorsCount { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}
