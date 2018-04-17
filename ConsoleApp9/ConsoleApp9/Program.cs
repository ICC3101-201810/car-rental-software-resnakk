using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            List<Accesorios> AccesoriosGenerales;
            Methods Methods = new Methods();
            while (true)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Ingrese una de las siguientes opciones:");
                Console.WriteLine("1.- Agregar Sucursal \n2.- Agregar vehiculos \n3.- Realizar venta");
                string orden = Console.ReadLine();
                if (orden == "1")
                {
                    Console.Clear();
                }
                else if (orden == "2")
                {
                    Console.Clear();
                    List<Accesorios> Lista1 = new List<Accesorios>();
                    Vehiculos.Add(Methods.AgregarVehiculo(Lista1));
                }
                else if (orden == "3")
                {
                    
                    Console.Clear();
                    
                }
            }
            
           



        }
    }
}
