using System;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using NMagickWand;
using NMagickWand.Enums;


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
        [Trait("area", "opt")]
        public void GetChannelMeanTest()
        {
            MagickWandApi.MagickWandGenesis();

            double a,b;

            foreach(var file in _files)
            {
                var wand = MagickWandApi.NewMagickWand();
                MagickWandApi.MagickReadImage(wand, file);

                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.BlackChannel, out a, out b);
                Console.WriteLine($"[{file}] [black] - mean: {a}, stddev: {b}");

                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.AllChannels, out a, out b);
                Console.WriteLine($"[{file}] [all] - mean: {a}, stddev: {b}");

                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.RGBChannels, out a, out b);
                Console.WriteLine($"[{file}] [rgb] - mean: {a}, stddev: {b}");

                MagickWandApi.DestroyMagickWand(wand);
            }

            MagickWandApi.MagickWandTerminus();
        }


        [Fact]
        [Trait("area", "opt")]
        public void PosterizeTest()
        {
            MagickWandApi.MagickWandGenesis();

            double a,b;

            foreach(var file in _files)
            {
                var wand = MagickWandApi.NewMagickWand();
                MagickWandApi.MagickReadImage(wand, file);

                MagickWandApi.MagickPosterizeImage(wand, (UIntPtr)3, MagickBooleanType.False);

                MagickWandApi.MagickGetImageChannelMean(wand, ChannelType.AllChannels, out a, out b);
                Console.WriteLine($"[{file}] [all] - mean: {a}, stddev: {b}");

                //MagickWandApi.MagickWriteImage(wand, "x_" + file);

                MagickWandApi.DestroyMagickWand(wand);
            }

            MagickWandApi.MagickWandTerminus();
        }
    }
}
