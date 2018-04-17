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
        public Int32 Precio;
       
        public  void AddAcc(string Acc)
        {
            Accesorios.Add(Acc);
        }
        public  List<string> GetAccs()
        {
             return this.Accesorios;
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
        public Auto(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Auto";
            Precio = P;
        }
    }
    class Acuatico : Vehiculo
    {
        public Acuatico(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Acuatico";
            Precio = P;
        }
    }
    class Moto : Vehiculo
    {
        public Moto(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Moto";
            Precio = P;
        }
    }
    class Camion : Vehiculo
    {
        public Camion(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Camion";
            Precio = P;
        }
    }
    class Bus : Vehiculo
    {
        public Bus(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Bus";
            Precio = P;
        }
    }
    class Maquinaria : Vehiculo
    {
        public Maquinaria(List<string> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Maquinaria";
            Precio = P;
        }
    }
}
