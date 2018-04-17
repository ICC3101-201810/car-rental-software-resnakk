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
                    C.Permiso = M.GetDoc();
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
                    C.Permiso = M.GetDoc();
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
                    C.Permiso = M.GetDoc();
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
                    C.Permiso = M.GetDoc();
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
                                    Ve.GetAccs().Add(i);
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
                                    Ve.GetAccs().Add(i);
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
                                    Ve.GetAccs().Add(i);
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
                                    Ve.GetAccs().Add(i);
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
                                    Ve.GetAccs().Add(i);
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
                    Console.WriteLine("Stock de Autos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Auto Autelio = new Auto(A, Documento, Precio,Stock);
                    return Autelio;
                }
                else if (V == "Acuatico")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Acuatico:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Stock de Acuaticos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Acuatico Autelio = new Acuatico(A, Documento, Precio, Stock);
                    return Autelio;
                }
                else if (V == "Moto")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio de la Moto:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Stock de Motos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Moto Autelio = new Moto(A, Documento, Precio, Stock);
                    return Autelio;
                }
                else if (V == "Camion")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Camion:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Stock de Autos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Camion Autelio = new Camion(A, Documento, Precio, Stock);
                    return Autelio;
                }
                else if (V == "Bus")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio del Bus:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Stock de Autos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Bus Autelio = new Bus(A, Documento, Precio, Stock);
                    return Autelio;
                }
                else if (V == "Maquinaria")
                {
                    Console.WriteLine("Tipo de permiso que necesita:");
                    string Documento = Console.ReadLine();
                    Console.WriteLine("Precio de la Maquinaria:");
                    Int32 Precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Stock de Autos:");
                    Int32 Stock = Int32.Parse(Console.ReadLine());
                    Maquinaria Autelio = new Maquinaria(A, Documento, Precio, Stock);
                    return Autelio;
                }
            }
        }
        public Arriendo ArrendarVehiculo(List<Vehiculo> L, List<Arriendo> A,Cliente C )
        {
            Console.WriteLine("Vehiculo a arrendar:");
            string V = Console.ReadLine();
            
            while (true)
            {
                if (V == "Auto" )
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Auto" && i.Stock > 0 && VerificarArriendo(C,i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i., date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Auto")
                        {
                            break;
                        }
                    }

                }
                else if (V == "Acuatico")
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Acuatico" && i.Stock > 0 && VerificarArriendo(C, i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i, date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Acuatico")
                        {
                            break;
                        }
                    }

                }
                else if (V == "Moto")
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Moto" && i.Stock > 0 && VerificarArriendo(C, i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i, date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Moto")
                        {
                            break;
                        }
                    }

                }
                else if (V == "Camion")
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Camion" && i.Stock > 0 && VerificarArriendo(C, i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i, date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Camion")
                        {
                            break;
                        }
                    }

                }
                else if (V == "Bus")
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Bus" && i.Stock > 0 && VerificarArriendo(C, i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i, date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Bus")
                        {
                            break;
                        }
                    }

                }
                else if (V == "Maquinaria")
                {
                    foreach (Vehiculo i in L)
                    {
                        if (i.Tipo == "Maquinaria" && i.Stock > 0 && VerificarArriendo(C, i) == true)
                        {
                            i.Stock--;
                            DateTime date = new DateTime();
                            Arriendo arriendo = new Arriendo(C, i, date.ToUniversalTime());
                            A.Add(arriendo);
                            break;
                        }
                        else if (i.Tipo == "Maquinaria")
                        {
                            break;
                        }
                    }

                }
            }
        }
        public void TipoPermiso(Cliente C,bool t, Vehiculo V)
        {
            if (t == true)
            {
                C.Permiso = V.GetDoc();
            }
            
        }
        public Vehiculo GetVehiculo(string a, List<Vehiculo> v)
        {
            while (true)
            {
                foreach (Vehiculo i in v)
                {
                    if (i.Tipo == a)
                    {
                        return i;
                    }

                }
                Console.WriteLine("Tipo de vehiculo;");
                a = Console.ReadLine();
            }
            
        }
        public Cliente GetCliente(string a, List<Arriendo> b)
        {
            while (true)
            {
                foreach (Arriendo s in b)
                {
                    Cliente a = s.Cliente())
                }
            }
        }
        public Cliente agregatCliente( string rut,string permiso, string tipo)
        {
            while (true)
            {
                if (tipo == "Persona")
                {
                    Persona P = new Persona(permiso, rut);
                    return P;
                }
                else if (tipo == "Empresa")
                {
                    Empresa P = new Empresa(permiso, rut);
                    return P;
                }
                if (tipo == "Organizacion")
                {
                    Organizacion P = new Organizacion(permiso, rut);
                    return P;
                }
                if (tipo == "Institucion")
                {
                    Institucion P = new Institucion(permiso, rut);
                    return P;
                }
            }
            
        }
        public bool RecibirVehiculo(string a,string b)
        {

        }
    }
}
