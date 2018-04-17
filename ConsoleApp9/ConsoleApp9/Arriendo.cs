using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Arriendo
    {
        Cliente Cliente;
        Vehiculo Vehiculo;
        DateTime Hora;
        public Arriendo(Cliente C,  Vehiculo V, DateTime D)
        {
            Cliente = C;
            Vehiculo = V;
            Hora = D;


        }
      
    }
}
