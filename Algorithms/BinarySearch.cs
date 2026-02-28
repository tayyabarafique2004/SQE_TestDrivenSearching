using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchLibrary.Models;

namespace SearchLibrary.Algorithms
{
    public class BinarySearch
    {
        public int Search(int key, Order[] orders)
        {
            int bottom = 0;
            int top = orders.Length - 1;

            while (bottom <= top)
            {
                int mid = (top + bottom) / 2;

                if (orders[mid].Id == key)
                {
                    return mid;
                }
                else if (orders[mid].Id < key)
                {
                    bottom = mid + 1;
                }
                else
                {
                    top = mid - 1;
                }
            }

            return -1;
        }
    }
}