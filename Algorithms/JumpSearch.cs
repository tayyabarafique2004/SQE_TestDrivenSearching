using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchLibrary.Models;

namespace SearchLibrary.Algorithms
{
    public class JumpSearch
    {
        public int Search(int key, Order[] orders)
        {
            int n = orders.Length;

            // ✅ FIX: handle empty array
            if (n == 0)
                return -1;

            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (orders[Math.Min(step, n) - 1].Id < key)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));

                if (prev >= n)
                    return -1;
            }

            for (int i = prev; i < Math.Min(step, n); i++)
            {
                if (orders[i].Id == key)
                    return i;
            }

            return -1;
        }
    }
}