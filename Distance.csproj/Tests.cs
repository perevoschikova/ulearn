using FluentAssertions;
using NUnit.Framework;

namespace DistanceTask
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            DistanceTask
                .GetDistanceToSegment(-30, 0, 30, 0, 60, 30)
                .Should().Be(42.4264068711929);
        }
    }
}
