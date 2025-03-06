using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Station
    {
        public int CircuitId { get; set; }
        public required Circuit Circuit { get; set; }
        public int ExerciseId { get; set; }
        public required Exercise Exercise { get; set; }
    }
}
