using System;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using NMagickWand;


namespace NMagickWand.Tests
{
    // these tests help to verify additional magickwand functions, and
    // additional motivation is to see if we can identify a night / sky
    // shot from other regular photos - which would allow for a generic/
    // automatic way to convert from raw optimally.
    public class OptimizationTests
    {
        static string[] _files = { "test.jpg", "daytest.jpg", "nighttest.jpg", "test2_night.jpg", "test3_night.jpg" };
        
        
        [Fact]
        public void GetChannelMeanTest()
        {
            MagickWandApi.MagickWandGenesis();
            
            double a = 0;
            double b = 0;
            
            foreach(var file in _files)
            {
                var wand = MagickWandApi.NewMagickWand();
                MagickWandApi.MagickReadImage(wand, file);
                
                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.BlackChannel, ref a, ref b);
                Console.WriteLine($"[{file}] [black] - mean: {a}, stddev: {b}");
                
                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.AllChannels, ref a, ref b);
                Console.WriteLine($"[{file}] [all] - mean: {a}, stddev: {b}");
                
                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.RGBChannels, ref a, ref b);
                Console.WriteLine($"[{file}] [rgb] - mean: {a}, stddev: {b}");
                
                MagickWandApi.DestroyMagickWand(wand);
            }
            
            MagickWandApi.MagickWandTerminus();
        }
        
        
        [Fact]
        public void PosterizeTest()
        {
            MagickWandApi.MagickWandGenesis();
            
            double a = 0;
            double b = 0;
            
            foreach(var file in _files)
            {
                var wand = MagickWandApi.NewMagickWand();
                MagickWandApi.MagickReadImage(wand, file);
                
                MagickWandApi.MagickPosterizeImage(wand, (UIntPtr)3, MagickBooleanType.False);
                
                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.AllChannels, ref a, ref b);
                Console.WriteLine($"[{file}] [all] - mean: {a}, stddev: {b}");
                
                //MagickWandApi.MagickWriteImage(wand, "x_" + file);
                
                MagickWandApi.DestroyMagickWand(wand);
            }
            
            MagickWandApi.MagickWandTerminus();
        }
    }
}
