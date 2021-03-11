using System;
using Xunit;

namespace DataWorks.Tests
{
    public class IsBracketsBalancedTests
    {
        [Fact]
        public void Tests()
        {
            Assert.True(DataWorks.IsBracketsBalanced("()"));
            Assert.True(DataWorks.IsBracketsBalanced("(())"));
            Assert.True(DataWorks.IsBracketsBalanced("(())"));
            Assert.True(DataWorks.IsBracketsBalanced("()()"));
            
            Assert.False(DataWorks.IsBracketsBalanced("()("));
            Assert.False(DataWorks.IsBracketsBalanced(")()"));
        }
        
    }
}