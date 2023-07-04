using CodeChallenges;
using Xunit;

namespace ArrayBinarySearchTests
{
  public class ArrayBinarySearchTest
  {
    [Fact]
    public void BinarySearch_Test()
    {
      int[] inputArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};
      int searchKey = 3;
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);
      Assert.Equal(result, 3);
    }
  }
}