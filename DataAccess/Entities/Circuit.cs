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
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime GoalReachedDate { get; set; } = DateTime.Now;
        public string? Note { get; set; }
    }
}
