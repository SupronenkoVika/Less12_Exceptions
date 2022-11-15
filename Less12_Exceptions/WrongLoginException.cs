namespace Less12_Exceptions
{
    class WrongLoginException : Exception
    {
        public WrongLoginException() { }
        public WrongLoginException(string message)
            : base(message) { }
    }
}
