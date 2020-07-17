using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using プロジェクト5.Models;

namespace プロジェクト5.Services
{
    public interface IEquipoRepository
    {
        public IEnumerable<Equipo> GetEquipos();
    }
}