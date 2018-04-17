using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Vehiculo
    {
        public List<string> Accesorios = new List<string>();
        public string Documentos;
        public string Tipo;
       
        public  void AddAcc(string Acc)
        {
            Accesorios.Add(Acc);
        }
        public  List<string> GetAccs(Vehiculo vehiculo)
        {
             return vehiculo.Accesorios;
        }   
        public string GetDoc()
        {
            return Documentos;
        }
        public string GetTipo()
        {
            return Tipo;
        }
    }
    class Auto : Vehiculo
    {
        public Auto(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Auto";
        }
    }
    class Acuatico : Vehiculo
    {
        public Acuatico(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Acuatico";
        }
    }
    class Moto : Vehiculo
    {
        public Moto(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Moto";
        }
    }
    class Camion : Vehiculo
    {
        public Camion(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Camion";
        }
    }
    class Bus : Vehiculo
    {
        public Bus(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Bus";
        }
    }
    class Maquinaria : Vehiculo
    {
        public Maquinaria(List<string> Ac, string Doc)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Maquinaria";
        }
    }
}
