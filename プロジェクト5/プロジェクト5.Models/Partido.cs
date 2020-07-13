using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Partido : BaseEntity
    {
        public int FechPart { get; set; }
        public TimeSpan TiemJugado { get; set; }
        public string Estadio { get; set; }

        //Equipo local
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }
        public int TotalJugLc { get; set; }

        //Equipo visitante
        [ForeignKey("EquipoSub")]
        public int IdEquipoSub { get; set; }
        public EquipoSub EquipoSub { get; set; }
        public int TotalJugVis { get; set; }

        //Navegabilidad
        public ICollection<ResultadoPartido> ResultadoPartidos { get; set; }
    }
}
