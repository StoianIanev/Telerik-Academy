using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Points
    {
        static void Main()
        {
            GenericList<int> array = new GenericList<int>(10);
            array.Add(6);
            array.Add(12);
            array.Add(3);
            array.Insert(7, 23);
            array.Insert(9, 54);
            string result = array.ToString();

        }
    }
}
