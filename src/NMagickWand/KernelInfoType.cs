namespace NMagickWand
{
    public enum KernelInfoType
    {
        UndefinedKernel,    /* equivalent to UnityKernel */
        UnityKernel,        /* The no-op or 'original image' kernel */
        GaussianKernel,     /* Convolution Kernels, Gaussian Based */
        DoGKernel,
        LoGKernel,
        BlurKernel,
        CometKernel,
        LaplacianKernel,    /* Convolution Kernels, by Name */
        SobelKernel,
        FreiChenKernel,
        RobertsKernel,
        PrewittKernel,
        CompassKernel,
        KirschKernel,
        DiamondKernel,      /* Shape Kernels */
        SquareKernel,
        RectangleKernel,
        OctagonKernel,
        DiskKernel,
        PlusKernel,
        CrossKernel,
        RingKernel,
        PeaksKernel,         /* Hit And Miss Kernels */
        EdgesKernel,
        CornersKernel,
        DiagonalsKernel,
        LineEndsKernel,
        LineJunctionsKernel,
        RidgesKernel,
        ConvexHullKernel,
        ThinSEKernel,
        SkeletonKernel,
        ChebyshevKernel,    /* Distance Measuring Kernels */
        ManhattanKernel,
        OctagonalKernel,
        EuclideanKernel,
        UserDefinedKernel,   /* User Specified Kernel Array */
        BinomialKernel
    }
}
