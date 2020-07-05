using System;

namespace ELearningService.Models
{

    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }


    }
}