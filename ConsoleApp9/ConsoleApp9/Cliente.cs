using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Cliente
    {
        public string Permiso;
        public string Rut;
        public string Tipo;

    }
    class  Persona : Cliente
    {
        public Persona(string P, string R)
        {
            Permiso = P;
            Rut = R;
            Tipo = "Persona";
        }
    }

    class Empresa : Cliente
    {
        public Empresa(string P, string R)
        {
            Permiso = P;
            Rut = R;
            Tipo = "Empresa";
        }
    }
    class Organizacion : Cliente
    {
        public Organizacion(string P, string R)
        {
            Permiso = P;
            Rut = R;
            Tipo = "Organizacion";
        }
    }
    class Institucion : Cliente
    {
        public Institucion(string P, string R)
        {
            Permiso = P;
            Rut = R;
            Tipo = "Institucion";
        }
    }




}

