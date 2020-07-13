using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プロジェクト5.Models
{
    public class UserPage : BaseEntity
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
    }
}
