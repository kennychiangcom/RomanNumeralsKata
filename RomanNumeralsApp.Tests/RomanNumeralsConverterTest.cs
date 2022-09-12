using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsApp.Tests
{
    public class RomanNumeralsConverterTest
    {
        private RomanNumeralsConverter _romanNumeralsConverter;

        [SetUp]
        public void Setup()
        {
            _romanNumeralsConverter = new RomanNumeralsConverter();
        }

        [Test]
        public void TestConvertingValidNumerals()
        {
            _romanNumeralsConverter.RConvert("i").Should().Be(1);
            _romanNumeralsConverter.RConvert("III").Should().Be(3);
            _romanNumeralsConverter.RConvert("iv").Should().Be(4);
            _romanNumeralsConverter.RConvert("vi").Should().Be(6);
            _romanNumeralsConverter.RConvert("viii").Should().Be(8);
            _romanNumeralsConverter.RConvert("MCMLXXXix").Should().Be(1989);
            _romanNumeralsConverter.RConvert("MMMDCCCLXXXVIII").Should().Be(3888);
        }
        [Test]
        public void TestConvertingInvalidNumerals()
        {
            _romanNumeralsConverter.RConvert("iiii").Should().Be(-1);
            _romanNumeralsConverter.RConvert("vv").Should().Be(-1);
            _romanNumeralsConverter.RConvert("xXxX").Should().Be(-1);
            _romanNumeralsConverter.RConvert("LL").Should().Be(-1);
            _romanNumeralsConverter.RConvert("CCCC").Should().Be(-1);
            _romanNumeralsConverter.RConvert("DD").Should().Be(-1);
            _romanNumeralsConverter.RConvert("MMMM").Should().Be(-1);
        }
    }
}
