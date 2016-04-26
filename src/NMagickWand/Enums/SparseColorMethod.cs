namespace NMagickWand.Enums
{
    public enum SparseColorMethod
    {
        UndefinedColorInterpolate = DistortImageMethod.UndefinedDistortion,
        BarycentricColorInterpolate = DistortImageMethod.AffineDistortion,
        BilinearColorInterpolate = DistortImageMethod.BilinearReverseDistortion,
        PolynomialColorInterpolate = DistortImageMethod.PolynomialDistortion,
        ShepardsColorInterpolate = DistortImageMethod.ShepardsDistortion,
        /*
          Methods unique to SparseColor().
        */
        VoronoiColorInterpolate = DistortImageMethod.SentinelDistortion,
        InverseColorInterpolate,
        ManhattanColorInterpolate
    }
}
