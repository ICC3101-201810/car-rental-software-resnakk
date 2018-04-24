using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public enum TipoC { Persona, Empresa, Organizacion, Institucion }
    abstract class Cliente
    {
        string Permiso;
        string Rut;

        public Cliente(string permiso, string rut)
        {
            Permiso = permiso;
            Rut = rut;
        }
        public string GetPermiso()
        {
            return this.Permiso;
        }
        public string GetRut()
        {
            return this.Rut;
        }
        public abstract TipoC GetTipoC();

    }
    class Persona : Cliente
    {
        TipoC Tipo;
        public Persona(string permiso, string rut)
            : base(permiso, rut)
        {
            Tipo = TipoC.Persona;
        }
        public override TipoC GetTipoC()
        {
            return this.Tipo;
        }
    }

    class Empresa : Cliente
    {
        TipoC Tipo;
        public Empresa(string permiso, string rut)
            : base(permiso, rut)
        {
            Tipo = TipoC.Empresa;
        }
        public override TipoC GetTipoC()
        {
            return this.Tipo;
        }
    }
    class Organizacion : Cliente
    {
        TipoC Tipo;
        public Organizacion(string permiso, string rut)
            : base(permiso, rut)
        {
            Tipo = TipoC.Organizacion;
        }
        public override TipoC GetTipoC()
        {
            return this.Tipo;
        }
    }
    class Institucion : Cliente
    {
        TipoC Tipo;
        public Institucion(string permiso, string rut)
            : base(permiso, rut)
        {
            Tipo = TipoC.Institucion;
        }
        public override TipoC GetTipoC()
        {
            return this.Tipo;
        }
    }




}

