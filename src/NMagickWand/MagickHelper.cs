using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;


namespace NMagickWand
{
    public delegate IntPtr MagickQueryStringListDelegate(string pattern, out UIntPtr count);
    public delegate IntPtr MagickWandQueryStringListDelegate(IntPtr wand, string pattern, out UIntPtr count);
    public delegate IntPtr MagickWandDoubleListDelegate(IntPtr wand, out UIntPtr count);
    public delegate IntPtr MagickWandPixelWandListDelegate(IntPtr wand, out UIntPtr count);


    public static class MagickHelper
    {
        public static string GetMagickString(IntPtr ptr)
        {
            if(ptr == IntPtr.Zero)
            {
                return null;
            }

            var str = Marshal.PtrToStringAnsi(ptr);

            MagickWandApi.MagickRelinquishMemory(ptr);

            return str;
        }


        public static string GetMagickString(IntPtr ptr, UIntPtr length)
        {
            if(ptr == IntPtr.Zero || length == UIntPtr.Zero)
            {
                return null;
            }

            return Marshal.PtrToStringAnsi(ptr, (int)length);
        }


        public static IReadOnlyList<string> GetMagickStringList(IntPtr arrayPtr, UIntPtr count)
        {
            var ptrs = GetMagickIntPtrArray(arrayPtr, count);

            return ptrs.Select(x => GetMagickString(x)).ToList();
        }


        public static IReadOnlyList<double> GetMagickDoubleList(IntPtr arrayPtr, UIntPtr count)
        {
            var result = GetMagickDoubleArray(arrayPtr, count);

            return new List<double>(result);
        }


        public static IReadOnlyList<PixelWand> GetMagickPixelWandList(IntPtr arrayPtr, UIntPtr count)
        {
            var result = GetMagickIntPtrArray(arrayPtr, count);

            return result.Select(x => new PixelWand(x)).ToList();
        }


        public static double[] GetMagickDoubleArray(IntPtr arrayPtr, UIntPtr count)
        {
            if(arrayPtr == IntPtr.Zero || count == UIntPtr.Zero)
            {
                return new double[0];
            }

            double[] result = new double[(int)count];
            Marshal.Copy(arrayPtr, result, 0, (int)count);

            MagickWandApi.MagickRelinquishMemory(arrayPtr);

            return result;
        }


        public static IntPtr[] GetMagickIntPtrArray(IntPtr arrayPtr, UIntPtr count)
        {
            if(arrayPtr == IntPtr.Zero || count == UIntPtr.Zero)
            {
                return new IntPtr[0];
            }

            IntPtr[] result = new IntPtr[(int)count];
            Marshal.Copy(arrayPtr, result, 0, (int)count);

            MagickWandApi.MagickRelinquishMemory(arrayPtr);

            return result;
        }


        public static IReadOnlyList<string> ExecuteMagickWandQueryStringList(IntPtr wand, string pattern, MagickWandQueryStringListDelegate del)
        {
            if(string.IsNullOrEmpty(pattern))
            {
                pattern = "*";
            }

            UIntPtr count;
            var strPtr = del(wand, pattern, out count);

            return MagickHelper.GetMagickStringList(strPtr, count);
        }


        public static IReadOnlyList<string> ExecuteMagickQueryStringList(string pattern, MagickQueryStringListDelegate del)
        {
            if(string.IsNullOrEmpty(pattern))
            {
                pattern = "*";
            }

            UIntPtr count;
            var strPtr = del(pattern, out count);

            return MagickHelper.GetMagickStringList(strPtr, count);
        }


        public static IReadOnlyList<double> ExecuteMagickWandDoubleList(IntPtr wand, MagickWandDoubleListDelegate del)
        {
            UIntPtr count;
            var strPtr = del(wand, out count);

            return MagickHelper.GetMagickDoubleList(strPtr, count);
        }


        public static IReadOnlyList<PixelWand> ExecuteMagickWandPixelWandList(IntPtr wand, MagickWandPixelWandListDelegate del)
        {
            UIntPtr count;
            var pwPtr = del(wand, out count);

            return MagickHelper.GetMagickPixelWandList(pwPtr, count);
        }
    }
}
