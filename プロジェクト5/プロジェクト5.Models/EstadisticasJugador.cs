using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace プロジェクト5.Models
{
    public class EstadisticasJugador
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Mins")]
        public int Minutos { get; set; }
        [Display(Name ="Asist")]
        public int Asistencias { get; set; }
        [Display(Name ="Amar")]
        public int TarjAmar { get; set; }
        [Display(Name="Roja")]
        public int TarjRoja { get; set; }
        [Display(Name ="TpP")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TirosporPart { get; set; }
        [Display(Name ="AP%")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AciertoPase { get; set; }
        [Display(Name ="Aéreos")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Aereos { get; set; }
        [Display(Name ="JdelP")]
        public bool JugadordelPart { get; set; }
        [Display(Name ="Rating")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        //Referencia
        [ForeignKey("Jugador")]
        public int IdJugador { get; set; }
        public Jugador Jugador { get; set; }
        [ForeignKey("Partido")]
        public int IdPartido { get; set; }
        public Partido Partido { get; set; }
    }
}
