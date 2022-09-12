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
        public void TestConvertingValidNumbers1()
        {
            _romanNumeralsConverter.NConvert(3888).Should().Be("MMMDCCCLXXXVIII");
        }

        [Test]
        public void TestConvertingValidNumbers2()
        {
            _romanNumeralsConverter.NConvert(1).Should().Be("I");
        }

        [Test]
        public void TestConvertingValidNumbers3()
        {
            _romanNumeralsConverter.NConvert(3).Should().Be("III");
        }

        [Test]
        public void TestConvertingValidNumbers4()
        {
            _romanNumeralsConverter.NConvert(74).Should().Be("LXXIV");
        }

        [Test]
        public void TestConvertingValidNumbers5()
        {
            _romanNumeralsConverter.NConvert(886).Should().Be("DCCCLXXXVI");
        }

        [Test]
        public void TestConvertingValidNumbers6()
        {
            _romanNumeralsConverter.NConvert(8).Should().Be("VIII");
        }

        [Test]
        public void TestConvertingValidNumbers7()
        {
            _romanNumeralsConverter.NConvert(1989).Should().Be("MCMLXXXIX");
        }

        [Test]
        public void TestConvertingValidNumbers8()
        {
            _romanNumeralsConverter.NConvert(3999).Should().Be("MMMCMXCIX");
        }

        [Test]
        public void TestConvertingInvalidNumbers()
        {
            _romanNumeralsConverter.NConvert(0).Should().Be("");
            _romanNumeralsConverter.NConvert(4000).Should().Be("");
            _romanNumeralsConverter.NConvert(-29).Should().Be("");
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
            _romanNumeralsConverter.RConvert("MMDM").Should().Be(-1);
            _romanNumeralsConverter.RConvert("LCX").Should().Be(-1);
            _romanNumeralsConverter.RConvert("CVXII").Should().Be(-1);
        }
    }
}
