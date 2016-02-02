namespace NMagickWand
{
    public enum MetricType
    {
        UndefinedMetric,
        AbsoluteErrorMetric,
        MeanAbsoluteErrorMetric,
        MeanErrorPerPixelMetric,
        MeanSquaredErrorMetric,
        PeakAbsoluteErrorMetric,
        PeakSignalToNoiseRatioMetric,
        RootMeanSquaredErrorMetric,
        NormalizedCrossCorrelationErrorMetric,
        FuzzErrorMetric,
        UndefinedErrorMetric = 0,
        PerceptualHashErrorMetric = 0xff
    }
}
