using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalayzerProblems1
{


    public class MoodAnalyserException : Exception
    {
        /// <summary>
        /// Enum of exception type.
        /// </summary>
        /// creating type variable of type ExceptionType
        ExceptionType type;
        readonly string message;

        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        /// <summary>
        /// parameterized contructor sets the Exception Type and message.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}