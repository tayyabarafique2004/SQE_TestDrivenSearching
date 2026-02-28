using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using SearchLibrary.Algorithms;
using SearchLibrary.Models;

namespace SearchLibrary.Tests
{
    public class JumpSearchTests
    {
        [Fact]
        public void Search_KeyExists_ReturnsCorrectIndex()
        {
            var orders = new Order[]
            {
                new Order(1, "A", 100),
                new Order(2, "B", 200),
                new Order(3, "C", 300),
                new Order(4, "D", 400)
            };

            var search = new JumpSearch();

            int result = search.Search(3, orders);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_KeyDoesNotExist_ReturnsMinusOne()
        {
            var orders = new Order[]
            {
                new Order(1, "A", 100),
                new Order(2, "B", 200),
                new Order(3, "C", 300)
            };

            var search = new JumpSearch();

            int result = search.Search(10, orders);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {
            var orders = new Order[] { };

            var search = new JumpSearch();

            int result = search.Search(1, orders);

            Assert.Equal(-1, result);
        }
    }
}