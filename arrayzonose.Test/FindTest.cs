using array;
using Xunit;

namespace arrayzonose.Test
{
    public class FindTest
    {
        string[] testArray = new string[] { "ana", "paula", "luiz", "beatriz", "afonso" };

        [Fact]
        public void Found()
        {
            int index = Program.Find(testArray, "luiz");

            Assert.Equal(2, index);
        }

        [Fact]
        public void NotFound()
        {
            int index = Program.Find(testArray, "JHENIFFFFEEER");

            Assert.Equal(-1, index);
        }
    }
}
