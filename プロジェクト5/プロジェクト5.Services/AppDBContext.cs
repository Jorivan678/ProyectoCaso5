﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;

namespace プロジェクト5.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<EquipoSub> EquipoSubs { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<ResultadoPartido> ResultadoPartidos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPage> UserPages { get; set; }
    }
}
