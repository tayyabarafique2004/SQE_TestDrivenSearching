using Xunit;
using SearchLibrary.Algorithms;
using SearchLibrary.Models;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SearchLibrary.Tests
{
    public class BinarySearchTests
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

            var search = new BinarySearch();

            int result = search.Search(3, orders);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_KeyLessThanAll_ReturnsMinusOne()
        {
            var orders = new Order[]
            {
                new Order(5, "A", 100),
                new Order(6, "B", 200),
                new Order(7, "C", 300)
            };

            var search = new BinarySearch();

            int result = search.Search(1, orders);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_KeyGreaterThanAll_ReturnsMinusOne()
        {
            var orders = new Order[]
            {
                new Order(1, "A", 100),
                new Order(2, "B", 200),
                new Order(3, "C", 300)
            };

            var search = new BinarySearch();

            int result = search.Search(10, orders);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {
            var orders = new Order[] { };

            var search = new BinarySearch();

            int result = search.Search(1, orders);

            Assert.Equal(-1, result);
        }
    }
}