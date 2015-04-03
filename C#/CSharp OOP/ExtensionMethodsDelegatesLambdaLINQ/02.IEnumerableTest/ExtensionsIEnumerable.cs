using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableTest
{
    public static class ExtensionsIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> s)
        {
            dynamic sum = 0;
            foreach (var S in s)
            {
                sum = sum + S;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> p)
        {
            dynamic pro = 1;
            foreach (var P in p)
            {
                pro = pro * P;
            }

            return pro;
        }

        private static T Min<T>(this IEnumerable<T> min)
        {
            dynamic m = 0;
            foreach (var mn in min)
            {
                if (m > mn)
                {
                    m = mn;
                }
                
            }
            return m;
        }

        public static T Max<T>(this IEnumerable<T> max)
        {
            dynamic mx = 0;
            foreach (var ma in max)
            {
                if (mx < ma)
                {
                    mx = ma;
                }

            }
            return mx;
        }

        public static T Average<T>(this IEnumerable<T> a)
        {
            dynamic sum = 0;
            int count = 0;
            foreach (var av in a)
            {
                sum = sum + av;
                count++;
            }
            if (count == 0)
                throw new ArgumentException("The passed collection is empty.");

            return sum / count;
        }
    }
}
