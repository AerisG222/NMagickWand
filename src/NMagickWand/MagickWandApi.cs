using System;
using System.Runtime.InteropServices;


namespace NMagickWand
{
    public static partial class MagickWandApi
    {
        public static string GetMagickString(IntPtr ptr)
        {
            var str = Marshal.PtrToStringAnsi(ptr);

            MagickWandApi.MagickRelinquishMemory(ptr);

            return str;
        }
    }
}
