﻿using System;

namespace ReCom.Exceptions
{
    public class NetworkException : Exception
    {
        public NetworkException(string message) : base(message)
        {
        }
    }

    public class NetworkProtocolException : NetworkException
    {
        public NetworkProtocolException(string message) : base(message)
        {
        }
    }
}
