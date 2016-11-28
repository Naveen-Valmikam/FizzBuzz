using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzerTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2 )]
        [InlineData(4)]
        public void GetValue_WhenNotAMultipleof3Or5_ReturnsInput(int input)
        {
            ArrangeActAssert(input, input.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void GetValue_WhenMultipleOf3_ReturnsFizz(int input)
        {
            ArrangeActAssert(input, "Fizz");
        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]       
        public void GetValue_WhenMultipleOf5_ReturnsBuzz(int input)
        {
            ArrangeActAssert(input, "Buzz");
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void GetValue_WhenMultipleOf3And5_ReturnsFizzBuzz(int input)
        {
            ArrangeActAssert(input, "FizzBuzz");
        }


        private void ArrangeActAssert(int input, string expected)
        {
            var buzzer = new FizzBuzzer();
            var actual = buzzer.GetValue(input);
            Assert.Equal(expected, actual);
        }
    }
}
