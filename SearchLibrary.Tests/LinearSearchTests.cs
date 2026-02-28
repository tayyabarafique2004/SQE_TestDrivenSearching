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
    }
}