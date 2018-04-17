using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Methods
    {
        public  Methods()
            {
            }
        public bool ConseguirPersmiso(Cliente C, Vehiculo M)
        {
            if (M.Tipo == "Maquinaria" && C.Tipo == "Empresa")
            {
                Random rnd = new Random();
                Int32 Prob = rnd.Next(0, 101);
                if (Prob <= 63)
                {
                    return true;
                }
                return false;
            }
            else if (M.Tipo == "Bus" && C.Tipo == "Empresa")
            {
                Random rnd = new Random();
                Int32 Prob = rnd.Next(0, 101);
                if (Prob <= 80)
                {
                    return true;
                }
                return false;
            }
            else if (M.Tipo == "Bus" && C.Tipo == "Organizacion")
            {
                Random rnd = new Random();
                Int32 Prob = rnd.Next(0, 101);
                if (Prob <= 35)
                {
                    return true;
                }
                return false;
            }
            else if (M.Tipo == "Bus" && C.Tipo == "Institucion")
            {
                Random rnd = new Random();
                Int32 Prob = rnd.Next(0, 101);
                if (Prob <= 58)
                {
                    return true;
                }
                return false;
            }
            else if (M.Tipo == "Bus" && C.Tipo == "Persona")
            {
                return false;
            }
            return false;
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

                        foreach (Accesorios i in Suc.GetAccesorios())
                        {
                            if (i.Tipo == "Gps")
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
                                if (i.Stock == 0)
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
        public bool VerificarArriendo(Cliente AA, Vehiculo BB)
        {

            if (AA.Tipo == "Persona" && AA.Permiso == BB.GetDoc())
            {
                if (BB.GetTipo() == "Bus")
                {
                    return false;
                }
                return true;
            }
            else if (AA.Tipo == "Empresa" && AA.Permiso == BB.GetDoc())
            {
                if (AA.Permiso == BB.GetDoc())
                {
                    return true;
                }
                else
                {
                    return ConseguirPersmiso(AA, BB);
                }
            }
            else if (AA.Tipo == "Organizacion" && AA.Permiso == BB.GetDoc())
            {
                if (BB.Tipo == "Maquinaria")
                {
                    return false;
                }
                else if (AA.Permiso == BB.GetDoc())
                {
                    return true;
                }
                else
                {
                    return ConseguirPersmiso(AA, BB);
                }
            }
            else if (AA.Tipo == "Institucion" && AA.Permiso == BB.GetDoc())
            {
                if (BB.Tipo == "Maquinaria")
                {
                    return false;
                }
                else if (AA.Permiso == BB.GetDoc())
                {
                    return true;
                }
                else
                {
                    return ConseguirPersmiso(AA, BB);
                }
            }
            return false;


        }
        public Vehiculo AgregarVehiculo( List<Accesorios> A)
        {

            while (true)
            {
                Console.WriteLine("Tipo de Vehiculo");
                string V = Console.ReadLine();
                if (V == "Auto")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Auto:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Auto Autelio = new Auto(A, Documento, Precio);
                    return Autelio;
                }
                else if (V == "Acuatico")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Acuatico:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Acuatico Autelio = new Acuatico(A, Documento, Precio);
                    return Autelio;
                }
                else if (V == "Moto")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio de la Moto:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Moto Autelio = new Moto(A, Documento, Precio);
                    return Autelio;
                }
                else if (V == "Camion")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Camion:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Camion Autelio = new Camion(A, Documento, Precio);
                    return Autelio;
                }
                else if (V == "Bus")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Bus:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Bus Autelio = new Bus(A, Documento, Precio);
                    return Autelio;
                }
                else if (V == "Maquinaria")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio de la Maquinaria:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Maquinaria Autelio = new Maquinaria(A, Documento, Precio);
                    return Autelio;
                }
            }
        }
        public Sucursal AgregarSucursal()
        {
            Console.WriteLine();
        }
    }
}
