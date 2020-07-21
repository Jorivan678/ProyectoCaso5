using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Jugador : BaseEntity
    {
        [Display(Name ="Nombre del Jugador")]
        public string NomJug { get; set; }
        [Display(Name = "Apellido paterno del Jugador")]
        public string ApellidoP { get; set; }
        [Display(Name = "Apellido materno del Jugador")]
        public string ApellidoM { get; set; }
        [Display(Name = "Posicion")]
        public string Posicion { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechNac { get; set; }
        [Display(Name = "Foto del Jugador")]
        public string FotoJug { get; set; }

        //Referencia
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

        //Navegabilidad
        public ICollection<ResultadoPartido> ResultadoPartidos { get; set; }
    }
}