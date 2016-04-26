using System.Runtime.InteropServices;


namespace NMagickWand.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ChannelFeatures
    {
        [FieldOffset(0)]
        double angular_second_moment;
        
        [FieldOffset(8)]
        double contrast;
        
        [FieldOffset(16)]
        double correlation;
        
        [FieldOffset(24)]
        double variance_sum_of_squares;
        
        [FieldOffset(32)]
        double inverse_difference_moment;
        
        [FieldOffset(40)]
        double sum_average;
        
        [FieldOffset(48)]
        double sum_variance;
        
        [FieldOffset(56)]
        double sum_entropy;
        
        [FieldOffset(64)]
        double entropy;
        
        [FieldOffset(72)]
        double difference_variance;
        
        [FieldOffset(80)]
        double difference_entropy;
        
        [FieldOffset(88)]
        double measure_of_correlation_1;
        
        [FieldOffset(96)]
        double measure_of_correlation_2;
        
        [FieldOffset(104)]
        double maximum_correlation_coefficient;
    }
}
