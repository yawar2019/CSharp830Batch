using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class AccessModifier
    {

         internal int a = 10;
    }

    class AccessModifier2
    {

      

        public void Add()
        {
            AccessModifier obj = new AccessModifier();
         
        }

    }
}
