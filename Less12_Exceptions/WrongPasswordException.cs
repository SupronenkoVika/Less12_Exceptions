namespace Less12_Exceptions
{
    class WrongPasswordException : Exception
    {
        public WrongPasswordException() { }
        public WrongPasswordException(string message)
            : base(message) { }
    }
}
