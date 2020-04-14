using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTareaListDGV_MamiferosAcuaticos
{
    class MamiferosAcuaticos
    {
        private int Id;
        private string nombre;
        private string especie;
        private string localizacion;
        public MamiferosAcuaticos(string nom, string esp, string loc)
        {
            nombre = nom;
            especie = esp;
            localizacion = loc;
        }
        public MamiferosAcuaticos()
        {
            nombre = string.Empty;
            especie = string.Empty;
            localizacion = string.Empty;
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public String Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }
    }
}
