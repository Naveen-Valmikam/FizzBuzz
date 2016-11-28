namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetValue(int input)
        {
            if (IsInputFizzBuzz(input))
                return "FizzBuzz";

            if (IsInputAFizz(input))
                return "Fizz";

            if (IsInputABuzz(input))
                return "Buzz";

            return input.ToString();
        }

        private bool IsInputAFizz(int input)
        {
            return input % 3 == 0;
        }

        private bool IsInputABuzz(int input)
        {
            return input % 5 == 0;
        }

        private bool IsInputFizzBuzz(int input)
        {
            return IsInputAFizz(input) && IsInputABuzz(input);
        }
    }
}
