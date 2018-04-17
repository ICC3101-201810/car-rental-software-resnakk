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
        public Arriendo(Cliente C, List<string> A)
        {
            Cliente = C;
            Accesorios = A;

        }
        public List<string> Pedidos()
        {
            while (true)
            {
                List<string> Lista1 = new List<string>();
                Console.WriteLine("1.- Agregar Accesorio");
                Console.WriteLine("2.- Terminar de Agregar Accesorios");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Que desea Agregar");
                    string Pedido = Console.ReadLine();
                    Lista1.Add(Pedido);   
                }
                if (Console.ReadLine() == "2")
                {
                    return Lista1;   
                }
            }
        }

        public bool VerArriendo(Cliente AA, Vehiculo BB)
        {
            
            if (AA.getPermiso() == BB.GetDoc())
            {
                return true;
            }
            if (BB.GetTipo() == "Maquinaria")
            {
                return false;
            }
            return false;
            
        }
    }
}
