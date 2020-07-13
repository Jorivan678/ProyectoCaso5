using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Jugador : BaseEntity
    {
        public string NomJug { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Posicion { get; set; }
        public DateTime FechNac { get; set; }
        public DateTime FechFich { get; set; }
        public byte[] FotoJug { get; set; }

        //Referencia
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

        //Navegabilidad
        public ICollection<ResultadoPartido> ResultadoPartidos { get; set; }
    }
}
