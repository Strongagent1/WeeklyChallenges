using System;
using System.Runtime.Serialization;

namespace ChallengesWithTestsMark8
{
    [Serializable]
    internal class NegativeFactorialShouldThrowArgumentOutOfRangeException : Exception
    {
        public NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
        }

        public NegativeFactorialShouldThrowArgumentOutOfRangeException(string message) : base(message)
        {
        }

        public NegativeFactorialShouldThrowArgumentOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeFactorialShouldThrowArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}