using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassLibrary
{
    internal class StudentClassLib
    {
        protected int a = 10;
    }

    internal class StudentClassLibrary2: StudentClassLib
    {
       public void show()
        {
            StudentClassLibrary2 obj = new StudentClassLibrary2();
             
        }
    }
}
