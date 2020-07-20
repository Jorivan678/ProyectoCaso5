using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class EquipoSub : BaseEntity
    {

        //Refencia a Equipo
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

        //Navegabilidad
        public ICollection<Partido> Partidos { get; set; }
    }
}
