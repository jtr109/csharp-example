using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void TestPrimeFactorOf4()
        {
            // arrange
            int a = 4;
            string expected = "2 x 2";
            PrimeFactorsClass pf = new();
            // act
            string actual = pf.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorOf7()
        {
            //arrange
            int a = 7;
            string expected = "7";
            PrimeFactorsClass pf = new();
            // act
            string actual = pf.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorOf30()
        {
            //arrange
            int a = 30;
            string expected = "5 x 3 x 2";
            PrimeFactorsClass pf = new();
            // act
            string actual = pf.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorOf40()
        {
            //arrange
            int a = 40;
            string expected = "5 x 2 x 2 x 2";
            PrimeFactorsClass pf = new();
            // act
            string actual = pf.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorOf50()
        {
            //arrange
            int a = 50;
            string expected = "5 x 5 x 2";
            PrimeFactorsClass pf = new();
            // act
            string actual = pf.PrimeFactors(a);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}