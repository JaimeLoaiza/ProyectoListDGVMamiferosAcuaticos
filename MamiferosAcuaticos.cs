﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTareaListDGV_MamiferosAcuaticos
{
    class MamiferosAcuaticos
    {
        private int identificacion;
        private string nombre;
        private string especie;
        private string localizacion;
        public MamiferosAcuaticos(int id, string nom, string esp, string loc)
        {
            identificacion = id;
            nombre = nom;
            especie = esp;
            localizacion = loc;
        }
        public MamiferosAcuaticos()
        {
            identificacion = 0;
            nombre = string.Empty;
            especie = string.Empty;
            localizacion = string.Empty;
        }
        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
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
