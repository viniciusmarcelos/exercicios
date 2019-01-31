using array;
using Xunit;

namespace arrayzonose.Test
{
    public class FillTest
    {
        string[] testArray = new string[50];

        [Fact]
        public void Trimmed()
        {
            const string fillString = "PAU NO CU DE QUEM TÁ LENDO!";

            string[] result = Program.Fill(testArray, fillString);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(fillString, result[i]);
            }
        }
    }
}
