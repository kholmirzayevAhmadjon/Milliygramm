﻿namespace Milliygramm.Service.Exceptions;

public sealed class ArgumentIsNotValidException : Exception
{
    public ArgumentIsNotValidException() { }
    public ArgumentIsNotValidException(string message) : base(message) { }
    public ArgumentIsNotValidException(string message, Exception exception) { }
    public int StatusCode => 400;
}
