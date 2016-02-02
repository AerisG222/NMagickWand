using System;


namespace NMagickWand
{
    public struct KernelInfo
    {
        KernelInfoType type;
        UIntPtr width;
        UIntPtr height;

        IntPtr x;
        IntPtr y;

        IntPtr values;  // double *
        double minimum;
        double maximum;
        double negative_range;
        double positive_range;
        double angle;

        IntPtr next;  // KernelInfo *

        UIntPtr signature;
    }
}
