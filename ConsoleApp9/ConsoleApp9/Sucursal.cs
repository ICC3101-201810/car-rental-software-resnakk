using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Sucursal
    {
        string Id;
        List<Accesorios> Accesorios;
        public Sucursal(string ID , List<Accesorios> Ac)
        {
            Id = ID;
            Accesorios = Ac;
        }

        public string GetId()
        {
            return Id;
        }
        public List<Accesorios> GetAccesorios()
        {
            return this.Accesorios;
        }
    }
    
}
