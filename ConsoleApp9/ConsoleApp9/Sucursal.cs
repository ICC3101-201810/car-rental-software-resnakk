using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Sucursal
    {
        public string Id;
        public Sucursal(string ID)
        {
            Id = ID;
        }

        public string GetId()
        {
            return Id;
        }
    }
    
}
