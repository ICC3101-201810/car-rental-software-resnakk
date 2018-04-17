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
        public int Stock;
       
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
        public Auto(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Auto";
            Precio = P;
            Stock = stock;
        }
    }
    class Acuatico : Vehiculo
    {
        public Acuatico(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Acuatico";
            Precio = P;
            Stock = stock;
        }
    }
    class Moto : Vehiculo
    {
        public Moto(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Moto";
            Precio = P;
            Stock = stock;
        }
    }
    class Camion : Vehiculo
    {
        public Camion(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Camion";
            Precio = P;
            Stock = stock;
        }
    }       
    class Bus : Vehiculo
    {
        public Bus(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Bus";
            Precio = P;
            Stock = stock;
        }
    }
    class Maquinaria : Vehiculo
    {
        public Maquinaria(List<Accesorios> Ac, string Doc, Int32 P, int stock)
        {
            Accesorios = Ac;
            Documentos = Doc;
            Tipo = "Maquinaria";
            Precio = P;
            Stock = stock;
        }
    }
}
