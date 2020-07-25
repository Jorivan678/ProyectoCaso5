using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace プロジェクト5.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        [Display(Name="Estado")]
        public bool Status { get; set; }
        [Display(Name ="Fecha de creación")]
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        [Display(Name = "Fecha de actualización")]
        public DateTime? UpdatedAT { get; set; }
    }
}