using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public required string NickName { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public List<Circuit> Circuits { get; set; } = [];
    }
}
