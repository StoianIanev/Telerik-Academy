using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubstringExtension
{
    public static class SubstringExtension
    {

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {

            return new StringBuilder(sb.ToString().Substring(index, length));
        }
    }
}
