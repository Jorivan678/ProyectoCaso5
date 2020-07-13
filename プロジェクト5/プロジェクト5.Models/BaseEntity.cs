using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdatedAT { get; set; }
    }
}
