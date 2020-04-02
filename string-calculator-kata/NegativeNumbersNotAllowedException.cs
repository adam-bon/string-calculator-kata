namespace string_calculator_kata
{
    public class NegativeNumbersNotAllowedException : System.Exception
    {
        public NegativeNumbersNotAllowedException(string message) : base(message) {
        }
        
    }
}