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
        public string GetPermiso()
        {
            return Permiso;
        }
        public string GetRut()
        {
            return Rut;
        }

    }
    class  Persona : Cliente
    {
        public Persona(string P, string R)
        {
            Permiso = P;
            Rut = R;
        }
    }

    class Empresa : Cliente
    {
        public Empresa(string P, string R)
        {
            Permiso = P;
            Rut = R;
        }
        public bool ConseguirPersmiso(Empresa E, Maquinaria M)
        {
            Random rnd = new Random();
            Int32 Prob = rnd.Next(0, 101);
            if (Prob <= 63)
            {
                return true;
            }
            return false;   
        }
    }
    class Organizacion : Cliente
    {
        public Organizacion(string P, string R)
        {
            Permiso = P;
            Rut = R;
        }
    }
            


}

