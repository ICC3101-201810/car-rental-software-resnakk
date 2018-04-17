using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Vehiculo
    {
        public List<Accesorios> Accesorios = new List<Accesorios>();
        public string Documentos;
        public string Tipo;
        public Int32 Precio;
       
        public  void AddAcc(Accesorios Acc)
        {
            Accesorios.Add(Acc);
        }
        public  List<Accesorios> GetAccs()
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
        public Auto(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Auto";
            Precio = P;
        }
    }
    class Acuatico : Vehiculo
    {
        public Acuatico(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Acuatico";
            Precio = P;
        }
    }
    class Moto : Vehiculo
    {
        public Moto(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Moto";
            Precio = P;
        }
    }
    class Camion : Vehiculo
    {
        public Camion(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Camion";
            Precio = P;
        }
    }       
    class Bus : Vehiculo
    {
        public Bus(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Bus";
            Precio = P;
        }
    }
    class Maquinaria : Vehiculo
    {
        public Maquinaria(List<Accesorios> Ac, string Doc, Int32 P)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Maquinaria";
            Precio = P;
        }
    }
}
