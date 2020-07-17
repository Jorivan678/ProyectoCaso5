using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using プロジェクト5.Models;

namespace プロジェクト5.Services
{
    public class EquipoRepository : SQLRepository<Equipo>, IEquipoRepository
    {
        public EquipoRepository(AppDBContext context) : base(context) { }

        public IEnumerable<Equipo> GetEquipos()
        {
            return context.Set<Equipo>().AsEnumerable();
        }
    }
}