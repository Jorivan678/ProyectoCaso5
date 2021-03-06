﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class Partido : BaseEntity
    {
        [Display(Name ="Fecha del Partido")]
        public DateTime FechPart { get; set; }
        [Display(Name ="Tiempo Jugado")]
        public TimeSpan TiemJugado { get; set; }
        [Display(Name ="Estadio")]
        [AllowNull]
        public string Estadio { get; set; }

        //Equipo local
        [ForeignKey("Equipo")]
        public int? IdEquipo { get; set; }
        public Equipo Equipo { get; set; }
        [Display(Name ="Cantidad de Jugadores Locales")]
        public int TotalJugLc { get; set; }

        //Equipo visitante
        [ForeignKey("EquipoSub")]
        public int? IdEquipoSub { get; set; }
        public EquipoSub EquipoSub { get; set; }
        [Display(Name = "Cantidad de Jugadores Visitantes")]
        public int TotalJugVis { get; set; }

        //Navegabilidad
        public ICollection<EstadisticasPartido> EstadisticasPartidos { get; set; }
        public ICollection<EstadisticasJugador> EstadisticasJugadores { get; set; }
    }
}
