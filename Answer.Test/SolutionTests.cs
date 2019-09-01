using NUnit.Framework;
using Answer;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(1, 2, 3, 1, ExpectedResult = true)]
        [TestCase(1, 2, 3, 4, ExpectedResult = false)]
        [TestCase(1, 1, 1, 3, 3, 4, 3, 2, 4, 2, ExpectedResult = true)]
        public bool ContainsDuplicate(params int[] nums)
        {
            var sut = new Solution();

            return sut.ContainsDuplicate(nums);
        }
    }
}