using System;
using System.Collections.Generic;
using System.Text;

namespace Zgaduj_Zgadula
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base("Niepoprawne dane logowania.") { }

        public InvalidLoginException(string message) : base(message) { }

        public InvalidLoginException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException() : base("Użytkownik o podanym loginie już istnieje.") { }

        public UserAlreadyExistsException(string message) : base(message) { }

        public UserAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
