using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Board
    {
        public byte Id { get; set; }    
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Task>? Tasks { get; set; }
    }
}
