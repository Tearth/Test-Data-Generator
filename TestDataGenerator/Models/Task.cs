using System.Collections.Generic;

namespace TestDataGenerator.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public IEnumerable<int> Times { get; set; }
    }
}
