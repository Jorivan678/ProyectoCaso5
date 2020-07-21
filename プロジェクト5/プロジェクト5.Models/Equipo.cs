using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Equipo : BaseEntity
    {
        [Display(Name="Nombre del Equipo")]
        public string NomEquip { get; set; }
        [Display(Name ="Logo del Equipo")]
        public string Logo { get; set; }

        //Navegabilidad
        public ICollection<Partido> Partidos { get; set; }
        public ICollection<EquipoSub> EquipoSubs { get; set; }
        public ICollection<Jugador> Jugadores { get; set; }
    }
}