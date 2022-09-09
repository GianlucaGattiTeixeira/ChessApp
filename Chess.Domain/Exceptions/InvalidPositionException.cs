using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Domain.Exceptions
{
    public class InvalidPositionException : Exception
    {
        public InvalidPositionException()
            : base("The position provided is not a valid chessbaord position"){ }
    }
}
