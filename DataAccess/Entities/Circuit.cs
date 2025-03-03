using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Circuit
    {
        public int CircuitId { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }
        public int GoalId { get; set; }
        public required Goal Goal { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
        public required List<Exercise> Exercises { get; set; }
        public int StartValue { get; set; }
        public int ResultValue { get; set; }
        public int AchievementRate { get; set; }
        public required string Note { get; set; }
    }
}
