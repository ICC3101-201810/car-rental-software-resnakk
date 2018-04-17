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
        public string getPermiso()
        {
            return Permiso;
        }
         
    }
    class  Persona : Cliente
    {
        public Persona(string P)
        {
            Permiso = P;
        }
    }

    class Empresa : Cliente
    {
        public Empresa(string P)
        {
            Permiso = P;
        }
    }
    class Organizacion : Cliente
    {
        public Organizacion(string P)
        {
            Permiso = P;
        }
    }
            


}

