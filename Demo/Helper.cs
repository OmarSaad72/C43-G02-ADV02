using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper
    {
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                    Sum += list[i];
            }
            return Sum;
        }
    }
}
