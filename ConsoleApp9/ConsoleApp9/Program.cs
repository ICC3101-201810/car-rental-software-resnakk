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
            List<Arriendo> Registros = new List<Arriendo>();
            Methods Methods = new Methods();
            while (true)
            {
                Console.WriteLine("Bienvenido!");
                Console.WriteLine("Ingrese una de las siguientes opciones:");
                Console.WriteLine("1.- Agregar Sucursal \n2.- Agregar vehiculos \n3.- Arrendar vehiculo \n4.- Recibir Vehiculo \n5.- Salir");
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
                    Console.WriteLine("Tipo de vehiculo:");
                    string k = Console.ReadLine();
                    Vehiculo h = Methods.GetVehiculo(k, Vehiculos);
                    Console.WriteLine("Tipo de Cliente:");
                    string T = Console.ReadLine();
                    Console.WriteLine("Rut de Cliente:");
                    string R = Console.ReadLine();
                    Console.WriteLine("si posee Permiso ingresarlo \nSi no posee ingrese 'no'");
                    string P = Console.ReadLine();
                    if (P != "no")
                    {
                        Cliente F = Methods.agregatCliente(R, P, T);
                        if (Methods.VerificarArriendo(F, h) == true)
                        {
                            Methods.ArrendarVehiculo(Vehiculos, Registros, F);
                        }

                    }
                    else
                    {
                        Cliente F = Methods.agregatCliente(R, P, T);
                        if (Methods.ConseguirPersmiso(F,h) == true)
                        {
                            Methods.ArrendarVehiculo(Vehiculos, Registros, F);
                        }
                    }

                   
                }
                else if (orden == "4")
                {
                    Console.Clear();
                    Console.WriteLine("rut cliente:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Tipo de auto que desea recibir:");
                    string b = Console.ReadLine();

                }
                else if (orden == "5")
                {
                    break;
                }
            }







        }
    }
}
