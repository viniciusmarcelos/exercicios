using array;
using Xunit;

namespace arrayzonose.Test
{
    public class MergeTest
    {
        string[] testArrayA = new string[] { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis" };
        string[] testArrayB = new string[] { "Sete", "Oito", "Nove", "Dez" };

        string[] expectedResult = new string[] { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez" };

        [Fact]
        public void Merged()
        {
            string[] result = Program.Join(testArrayA, testArrayB);

            Assert.Equal(expectedResult.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
