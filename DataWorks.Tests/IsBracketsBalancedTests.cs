using System;
using Xunit;

namespace DataWorks.Tests
{
    public class IsBracketsBalancedTests
    {
        [Fact]
        public void Should_Return_True()
        {
            Assert.True(DataWorks.IsBracketsBalanced("()"));
            Assert.True(DataWorks.IsBracketsBalanced("(())"));
            Assert.True(DataWorks.IsBracketsBalanced("(())"));
            Assert.True(DataWorks.IsBracketsBalanced("()()"));
        }

        [Fact]
        public void Should_Return_False()
        {
            Assert.False(DataWorks.IsBracketsBalanced("()("));
            Assert.False(DataWorks.IsBracketsBalanced(")()"));
        }

        [Fact]
        public void Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() => DataWorks.IsBracketsBalanced(""));
        }
        
    }
}