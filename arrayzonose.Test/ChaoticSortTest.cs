using array;
using Xunit;

namespace arrayzonose.Test
{
    public class ChaoticSortTest
    {
        string[] testArray = new string[] { "ana", "paula", "luiz", "beatriz", "afonso", "beatriz" };

        string[] expectedResult = new string[] { "afonso", "ana", "beatriz", "beatriz", "luiz", "paula" };

        //[Fact]
        //public void ChaoticSort()
        //{
        //    Program.ChaoticSort(testArray);

        //    for (int i = 0; i < testArray.Length; i++)
        //    {
        //        Assert.Equal(expectedResult[i], testArray[i]);
        //    }
        //}
    }
}
