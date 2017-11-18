using System;
using Xunit;
using GameOfLife;
using FluentAssertions;

namespace GameOfLifeTests
{
    public class UnitTest1
    {
        private FirstClass _sut;

        public UnitTest1()
        {
            _sut = new FirstClass();
        }

        [Fact]
        public void Test1()
        {
            var result = _sut.DoIt();

            result.Should().BeTrue();
        }
    }
}
