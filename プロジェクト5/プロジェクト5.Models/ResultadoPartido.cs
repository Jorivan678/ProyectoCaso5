using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class ResultadoPartido : BaseEntity
    {
        [Display(Name ="Goles anotados")]
        public int Goles { get; set; }
        [Display(Name ="Asistencias")]
        public int Asistencias { get; set; }
        [Display(Name ="Autogoles anotados")]
        public int AutoGoles { get; set; }
        [Display(Name ="Penales anotados")]
        public int Penales { get; set; }
        [Display(Name =("Tarjetas amarillas adquiridas"))]
        public int TarjAmarilla { get; set; }
        [Display(Name ="Tarjetas rojas adquiridas")]
        public int TarjRoja { get; set; }

        //Referencia
        [ForeignKey("Partido")]
        public int IdPartido { get; set; }
        public Partido Partido { get; set; }

        [ForeignKey("Jugador")]
        public int IdJugador { get; set; }
        public Jugador Jugador { get; set; }
    }
}
