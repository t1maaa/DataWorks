using Xunit;

namespace DataWorks.Tests
{
    public class RomanToIntTests
    {
        [Theory,
         InlineData(1, "I"),
         InlineData(2, "II"),
         InlineData(3, "III"),
         InlineData(4, "IV"),
         InlineData(5, "V"),
         InlineData(6, "VI"),
         InlineData(7, "VII"),
         InlineData(8, "VIII"),
         InlineData(9, "IX"),
         InlineData(10,"X"),
         InlineData(11, "XI"),
         InlineData(12, "XII"),
         InlineData(14, "XIV"),
         InlineData(15, "XV"),
         InlineData(16, "XVI"),
         InlineData(19, "XIX"),
         InlineData(20, "XX"),
         InlineData(21, "XXI"),
         InlineData(22, "XXII"),
         InlineData(24, "XXIV"),
         InlineData(25, "XXV"),
         InlineData(26, "XXVI"),
         InlineData(29, "XXIX"),
         InlineData(30, "XXX"),
         InlineData(40, "XL"),
         InlineData(41, "XLI"),
         InlineData(42, "XLII"),
         InlineData(44, "XLIV"),
         InlineData(45, "XLV"),
         InlineData(46, "XLVI"),
         InlineData(49, "XLIX"),
         InlineData(50, "L"),
         InlineData(51, "LI"),
         InlineData(52, "LII"),
         InlineData(54, "LIV"),
         InlineData(55, "LV"),
         InlineData(56, "LVI"),
         InlineData(59, "LIX"),
         InlineData(60, "LX"),
         InlineData(90, "XC"),
         InlineData(91, "XCI"),
         InlineData(92, "XCII"),
         InlineData(94, "XCIV"),
         InlineData(95, "XCV"),
         InlineData(96, "XCVI"),
         InlineData(99, "XCIX"),
         InlineData(100,"C"),
         InlineData(899,"DCCCXCIX"),
         InlineData(990,"CMXC"),
         InlineData(999,"CMXCIX"),
         InlineData(1000, "M"),
         InlineData(2500, "MMD"),
         InlineData(2999, "MMCMXCIX")
        ]
        public void ValidValues_Ok(int expected, string romanValue)
        {
            Assert.Equal(expected, DataWorks.RomanToInt(romanValue));
        }

        [Theory,
         InlineData(0, "@"),
         InlineData(10, "@X"),
         InlineData(10, "@@X"),
         InlineData(10, "X@"),
         InlineData(10, "X@@"),
         InlineData(11, "X@I"),
         InlineData(11, "X@I@"),
        ]
        public void WithNotValidChars(int expected, string romanValue)
        {
            Assert.Equal(expected, DataWorks.RomanToInt(romanValue));
        }
        
        [Fact]
        public void ZeroAsString()
        {
            Assert.Equal(0, DataWorks.RomanToInt("0"));
        }
    }
}   