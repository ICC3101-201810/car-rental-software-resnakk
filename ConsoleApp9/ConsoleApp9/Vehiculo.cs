using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public enum TipoV { Auto, Acuatico, Moto, Camion, Bus, MAquinaria }
    abstract class Vehiculo
    {
        List<Accesorios> Accesorios;
        string Documentos;
        int Precio;
        int Stock;
        public Vehiculo(List<Accesorios> accesorios, string documentos, int precio, int stock)
        {
            Accesorios = accesorios;
            Documentos = documentos;
            Precio = precio;
            Stock = stock;
        }
        public void AddAcc(Accesorios Acc){Accesorios.Add(Acc);}
        public List<Accesorios> GetAccs() { return this.Accesorios; }
        public string GetDoc() { return this.Documentos; }
        public abstract TipoV GetTipoV();
    }


    
    class Auto : Vehiculo
    {
        TipoV Tipo;
        public Auto(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.Auto;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }
    }
    
    class Acuatico : Vehiculo
    {
        TipoV Tipo;
        public Acuatico(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.Acuatico;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }

    }
    class Moto : Vehiculo
    {
        TipoV Tipo;
        public Moto(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.Moto;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }
    }
    class Camion : Vehiculo
    {
        TipoV Tipo;
        public Camion(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.Camion;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }
    }       
    class Bus : Vehiculo
    {
        TipoV Tipo;
        public Bus(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.Bus;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }
    }
    class Maquinaria : Vehiculo
    {
        TipoV Tipo;
        public Maquinaria(List<Accesorios> Ac, string Doc, int P, int stock)
            : base(Ac, Doc, P, stock)
        {
            Tipo = TipoV.MAquinaria;
        }
        public override TipoV GetTipoV()
        {
            return this.Tipo;
        }
    }
}
