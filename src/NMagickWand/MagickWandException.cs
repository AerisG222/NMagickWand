using System;
using NMagickWand.Enums;


namespace NMagickWand
{
    public class MagickWandException
        : Exception
    {
        public ExceptionType MagickWandExceptionType { get; private set; }
        
        
        public MagickWandException()
            : this(ExceptionType.UndefinedException, null)
        {
            // do nothing
        }
        
        
        public MagickWandException(string message)
            : this(ExceptionType.UndefinedException, message)
        {
            // do nothing
        }
        
        
        public MagickWandException(ExceptionType type)
            : this(type, null)
        {
            // do nothing
        }
        
        
        public MagickWandException(ExceptionType type, string message)
            : base(message)
        {
            MagickWandExceptionType = type;
        }
    }
}