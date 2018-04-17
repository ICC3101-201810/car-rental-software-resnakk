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
        public void Pedidos(Sucursal Suc, Vehiculo Ve, Int32 CostoT)
        {
            CostoT += Ve.Precio;
            while (true)
            {
                
                Console.WriteLine("1.- Agregar Accesorio");
                Console.WriteLine("2.- Terminar de Agregar Accesorios");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Que desea Agregar:");
                    Console.WriteLine("1.-GPS \n2.- Bluetooth \n3.- Rueda Extra \n4.- Cortinas \n5.- Silla Extra");
                    string Pedido = Console.ReadLine();
                    if (Pedido == "1")
                    {
                        
                        foreach(Accesorios i in Suc.GetAccesorios())
                        {
                            if ( i.Tipo == "Gps")
                            {
                                if (i.Stock == 0)
                                {
                                    Console.WriteLine("No Tenemos GPS");
                                }
                                else
                                {
                                    Ve.GetAccs().Add(i.Tipo);
                                    i.Stock--;
                                    CostoT += i.Precio;
                                }

                            }
                        }

                    }
                    else if (Pedido == "2")
                    {
                        foreach (Accesorios i in Suc.GetAccesorios())
                        {
                            if (i.Tipo == "Bluetooth")
                            {
                                if(i.Stock == 0)
                                {
                                    Console.WriteLine("No Tenemos Bluetooth");
                                }
                                else
                                {
                                    Ve.GetAccs().Add(i.Tipo);
                                    i.Stock--;
                                    CostoT += i.Precio;
                                }
                            }
                        }
                    }
                    else if (Pedido == "3")
                    {
                        foreach (Accesorios i in Suc.GetAccesorios())
                        {
                            if (i.Tipo == "Rueda")
                            {
                                if (i.Stock == 0)
                                {
                                    Console.WriteLine("No tenemos ruedas extras");
                                }
                                else
                                {
                                    Ve.GetAccs().Add(i.Tipo);
                                    i.Stock--;
                                    CostoT += i.Precio;
                                }
                            }
                        }
                    }
                    else if (Pedido == "4")
                    {
                        foreach (Accesorios i in Suc.GetAccesorios())
                        {
                            if (i.Tipo == "Cortina")
                            {
                                if (i.Stock == 0)
                                {
                                    Console.WriteLine("No Tenemos Cortinas");
                                }
                                else
                                {
                                    Ve.GetAccs().Add(i.Tipo);
                                    i.Stock--;
                                    CostoT += i.Precio;
                                }
                            }
                        }
                    }
                    else if (Pedido == "5")
                    {
                        foreach (Accesorios i in Suc.GetAccesorios())
                        {
                            if (i.Tipo == "Silla")
                            {
                                if (i.Stock == 0)
                                {
                                    Console.WriteLine("No Tenemos Sillas");
                                }
                                else
                                {
                                    Ve.GetAccs().Add(i.Tipo);
                                    i.Stock--;
                                    CostoT += i.Precio;
                                }
                            }
                        }
                    }
                }
                if (Console.ReadLine() == "2")
                {
                    break;   
                }
            }
        }

        public bool VerArriendoP(Persona AA, Vehiculo BB)
        {
            
            if (AA.GetPermiso() == BB.GetDoc())
            {
                if (BB.GetTipo() == "Bus")
                {
                    return false;
                }
                return true;
            }
            else 
            {
                return false;
            }
            
            
            
        }
        //public bool VerArriendoE()
    }
}
