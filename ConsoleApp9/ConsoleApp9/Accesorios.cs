using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    
    class Accesorios
    {
        public Int32 Stock;
        public Int32 Precio;
        public string Nombre;
        public string Tipo;    
    }
    class Gps : Accesorios
    {
        public Gps(Int32 S, string N, Int32 P)
        {
            Stock = S;
            Nombre = N;
            Tipo = "Gps";
            Precio = P;
        }
    }
    class Bluetooth : Accesorios
    {
        public Bluetooth(Int32 S, string N, Int32 P)
        {
            Stock = S;
            Nombre = N;
            Tipo = "Bluetooth";
            Precio = P;
        }
    }
    class RuedaE : Accesorios
    {
        public RuedaE(Int32 S, string N, Int32 P)
        {
            Stock = S;
            Nombre = N;
            Tipo = "Rueda";
            Precio = P;
        }
    }
    class Cortinas : Accesorios
    {
        public Cortinas(Int32 S, string N, Int32 P)
        {
            Stock = S;
            Nombre = N;
            Tipo = "Cortina";
            Precio = P;
        }
    }
    class Sillas : Accesorios
    {
        public Sillas(Int32 S, string N, Int32 P)
        {
            Stock = S;
            Nombre = N;
            Tipo = "Silla";
            Precio = P;
        }
    }
}
