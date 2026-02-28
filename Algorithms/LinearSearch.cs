using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchLibrary.Models;

namespace SearchLibrary.Algorithms
{
    public class LinearSearch
    {
        public int Search(int key, Order[] orders)
        {
            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].Id == key)
                    return i;
            }

            return -1;
        }
    }
}