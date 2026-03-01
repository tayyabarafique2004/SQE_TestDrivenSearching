using Xunit;
using SearchLibrary.Algorithms;
using SearchLibrary.Models;

namespace SearchLibrary.Tests
{
    public class LinearSearchTests
    {
        [Fact]
        public void Search_KeyExists_ReturnsIndex()
        {
            var orders = new Order[]
            {
                new Order(1, "A", 100),
                new Order(2, "B", 200),
                new Order(3, "C", 300)
            };

            var search = new LinearSearch();

            int result = search.Search(2, orders);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Search_KeyDoesNotExist_ReturnsMinusOne()
        {
            var orders = new Order[]
            {
                new Order(1, "A", 100),
                new Order(2, "B", 200)
            };

            var search = new LinearSearch();

            int result = search.Search(5, orders);

            Assert.Equal(-1, result);
        }
        [Fact]
        public void Search_TargetAtStart_ReturnsIndex()
        {
            var orders = new Order[] { new Order(1, "A", 100), new Order(2, "B", 200) };
            var search = new LinearSearch();
            int result = search.Search(1, orders);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_TargetAtEnd_ReturnsIndex()
        {
            var orders = new Order[] { new Order(1, "A", 100), new Order(2, "B", 200) };
            var search = new LinearSearch();
            int result = search.Search(2, orders);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Search_SingleElementArray_ReturnsIndex()
        {
            var orders = new Order[] { new Order(7, "G", 700) };
            var search = new LinearSearch();
            int result = search.Search(7, orders);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_TargetBelowRange_ReturnsMinusOne()
        {
            var orders = new Order[] { new Order(5, "E", 500), new Order(6, "F", 600) };
            var search = new LinearSearch();
            int result = search.Search(4, orders);
            Assert.Equal(-1, result);
        }
    }
}