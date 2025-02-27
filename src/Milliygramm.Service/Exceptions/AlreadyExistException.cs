﻿namespace Milliygramm.Service.Exceptions;

public sealed class AlreadyExistException : Exception
{
    public AlreadyExistException() { }
    public AlreadyExistException(string message) : base(message) { }
    public AlreadyExistException(string message, Exception exception) { }
    public int StatusCode => 409;
}