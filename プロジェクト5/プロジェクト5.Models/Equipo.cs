using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Equipo : BaseEntity
    {
        public string NomEquip { get; set; }
        public byte[] Logo { get; set; }

        //Navegabilidad
        public ICollection<Partido> Partidos { get; set; }
        public ICollection<EquipoSub> EquipoSubs { get; set; }
        public ICollection<Jugador> Jugadores { get; set; }
    }
}