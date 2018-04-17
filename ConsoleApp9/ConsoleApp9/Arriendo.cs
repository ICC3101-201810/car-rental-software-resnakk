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
        List<string> Accesorios;
        Vehiculo Vehiculo;
        DateTime Hora;
        public Arriendo(Cliente C, List<string> A, Vehiculo V, DateTime D)
        {
            Cliente = C;
            Accesorios = A;
            Vehiculo = V;
            Hora = D;


        }
        

        
        //public bool VerArriendoE()
    }
}
