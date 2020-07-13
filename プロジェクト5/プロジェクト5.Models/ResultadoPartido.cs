using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class ResultadoPartido : BaseEntity
    {
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int AutoGoles { get; set; }
        public int Penales { get; set; }
        public int TarjAmarilla { get; set; }
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
