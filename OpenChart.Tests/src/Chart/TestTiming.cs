using NUnit.Framework;
using OpenChart.Chart;
using System;

namespace OpenChart.Tests.Chart
{
    public class TestTiming
    {
        [TestCase(-1)]
        [TestCase(-0.001)]
        public void Test_NegativeBeat(double value)
        {
            Assert.Throws<ArgumentException>(() => new Timing(value));
        }

        [TestCase(0)]
        [TestCase(1)]
        public void Test_NonNegativeBeat(double value)
        {
            Assert.DoesNotThrow(() => new Timing(value));
        }
    }
}