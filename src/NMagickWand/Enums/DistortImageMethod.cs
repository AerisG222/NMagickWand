namespace NMagickWand.Enums
{
    public enum DistortImageMethod
    {
        UndefinedDistortion,
        AffineDistortion,
        AffineProjectionDistortion,
        ScaleRotateTranslateDistortion,
        PerspectiveDistortion,
        PerspectiveProjectionDistortion,
        BilinearForwardDistortion,
        BilinearDistortion = BilinearForwardDistortion,
        BilinearReverseDistortion,
        PolynomialDistortion,
        ArcDistortion,
        PolarDistortion,
        DePolarDistortion,
        Cylinder2PlaneDistortion,
        Plane2CylinderDistortion,
        BarrelDistortion,
        BarrelInverseDistortion,
        ShepardsDistortion,
        ResizeDistortion,
        SentinelDistortion
    }
}
