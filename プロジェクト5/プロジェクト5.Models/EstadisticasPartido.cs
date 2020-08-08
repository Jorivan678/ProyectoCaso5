using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class EstadisticasPartido
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Campeonato")]
        public string Championship { get; set; }
        [Display(Name ="Goles")]
        public int Goles { get; set; }
        [Display(Name ="Tirospp")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tiros { get; set; }
        [Display(Name ="Posesion%")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Posesion { get; set; }
        [Display(Name ="AciertoPase%")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Aciertos { get; set; }
        [Display(Name ="Aéreos")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Aereos { get; set; }
        [Display(Name ="Rating")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        //Referencia
        [ForeignKey("Partido")]
        public int IdPartido { get; set; }
        public Partido Partido { get; set; }
    }
}