using System;


namespace NMagickWand.Structs
{
    public struct ChannelStatistics 
    {
        UIntPtr depth;
        
        double minima;
        double maxima;
        double sum;
        double sum_squared;
        double sum_cubed;
        double sum_fourth_power;
        double mean;
        double variance;
        double standard_deviation;
        double kurtosis;
        double skewness;
        double entropy;
    }
}
