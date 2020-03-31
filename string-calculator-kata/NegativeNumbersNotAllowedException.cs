namespace string_calculator_kata
{
    public class NegativeNumbersNotAllowedException : System.Exception
    {
        public NegativeNumbersNotAllowedException() : base() { }
        public NegativeNumbersNotAllowedException(string message) : base(message) { 
        }
        public NegativeNumbersNotAllowedException(string message, System.Exception inner) : base(message, inner) { }
        
        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected NegativeNumbersNotAllowedException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}