using array;
using Xunit;

namespace arrayzonose.Test
{
    public class TrimTest
    {
        string[] testArray = new string[] { "", "Dilma", "", "", "Lula", "", "", "", "Jair", "" };

        string[] expectedResult = new string[] { "Dilma", "Lula", "Jair" };

        [Fact]
        public void Trimmed()
        {
            string[] result = Program.Trim(testArray);

            Assert.Equal(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
