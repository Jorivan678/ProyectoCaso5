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
        [Display(Name ="Añadido el")]
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        [Display(Name = "Actualizado el")]
        public DateTime? UpdatedAT { get; set; } = DateTime.Now;
    }
}