﻿using System;

namespace MNIST_Neural_Network
{
    class SizeFileException : ApplicationException
    {
        public SizeFileException()
            : base("Not the right size of the file.")
        { }
    }
}