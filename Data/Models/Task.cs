using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdate { get; set;}
        public byte Priority { get; set; }
        public ICollection<string>? Tags { get; set; }
        public byte BoardId { get; set; }
        public required Board Board { get; set; }    

    }
}
