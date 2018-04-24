using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public enum TipoA { Gps, Bluetooth, Rueda, Cortina, Silla}
    abstract class Accesorios
    {
        int Stock;
        int Precio;
        string Nombre;
        public Accesorios(int stock ,int precio, string nombre)
        {
            Stock = stock;
            Precio = precio;
            Nombre = nombre;
        }
        public int GetStock() { return this.Stock; }
        public int GetPrecio() { return this.Precio; } 
        public string GetNombre() { return this.Nombre; }
        public abstract TipoA GetTipoA();
    }
    class Gps : Accesorios
    {
        TipoA Tipo;
        public Gps(int S, int P, string N) : base(S, P, N) 
        {
            Tipo = TipoA.Gps;
        }
        public override TipoA GetTipoA() { return this.Tipo; }
        
    }
    class Bluetooth : Accesorios
    {
        TipoA Tipo;
        public Bluetooth(int S, int P, string N) : base(S, P, N)
        {
            Tipo = TipoA.Bluetooth;
        }
        public override TipoA GetTipoA() { return this.Tipo; }

    }
    class Rueda : Accesorios
    {
        TipoA Tipo;
        public Rueda(int S, int P, string N) : base(S, P, N)
        {
            Tipo = TipoA.Rueda;
        }
        public override TipoA GetTipoA() { return this.Tipo; }

    }
    class Cortina : Accesorios
    {
        TipoA Tipo;
        public Cortina(int S, int P, string N) : base(S, P, N) 
        {
            Tipo = TipoA.Cortina;
        }
        public override TipoA GetTipoA() { return this.Tipo; }
        
    }
    class Silla : Accesorios
    {
        TipoA Tipo;
        public Silla(int S, int P, string N) : base(S, P, N)
        {
            Tipo = TipoA.Silla;
        }
        public override TipoA GetTipoA() { return this.Tipo; }

    }
}
