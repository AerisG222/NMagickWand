using System;
using System.IO;
using Xunit;
using NMagickWand;
using NMagickWand.Enums;


namespace NMagickWand.Tests
{
    public class WrapperTests
    {
        const bool KEEP_FILES = true;


        [Fact]
        [Trait("area", "wrap")]
        public void MakeThumbnail()
        {
            var file = "test2.jpg";

            MagickWandEnvironment.Genesis();

            using(var mw = new MagickWand())
            {
                mw.ReadImage("test.jpg");
                mw.ScaleImage(120, 100);
                mw.WriteImage(file, true);

                Assert.True(File.Exists(file), "scaled image not created");
            }

            using(var mw = new MagickWand(file))
            {
                Assert.True(mw.ImageWidth == 120, "width does not match the expected size");
                Assert.True(mw.ImageHeight == 100, "height does not match the expected size");
            }

            File.Delete(file);

            MagickWandEnvironment.Terminus();
        }


        [Fact]
        [Trait("area", "wrap")]
        public void Resize()
        {
            var file = "test3.jpg";

            MagickWandEnvironment.Genesis();

            using(var mw = new MagickWand())
            {
                mw.ReadImage("test.jpg");
                mw.ResizeImage(120, 100, FilterTypes.LanczosFilter, 1);
                mw.WriteImage(file, true);

                Assert.True(File.Exists(file), "scaled image not created");
            }

            using(var mw = new MagickWand(file))
            {
                Assert.True(mw.ImageWidth == 120, "width does not match the expected size");
                Assert.True(mw.ImageHeight == 100, "height does not match the expected size");
            }

            File.Delete(file);

            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact]
        [Trait("area", "wrap")]
        public void TestWrapperAndStringQueryFuncs()
        {
            MagickWandEnvironment.Genesis();

            using(var mi = new MagickWand())
            {
                mi.ReadImage(TestHelper.TEST_FILE);

                var list = mi.GetImageProperties(string.Empty);

                Assert.True(list != null, "the list should not be null");
                Assert.True(list.Count > 0, "there should be more than 1 profile");

                foreach(var item in list)
                {
                    Console.WriteLine($"profile: {item}");
                }
            }

            MagickWandEnvironment.Terminus();
        }


        [Fact]
        [Trait("area", "wrap")]
        public void TestNightOptimizations()
        {
            MagickWandEnvironment.Genesis();
            
            using(var mw = new MagickWand("nighttest.jpg"))
            {
                using(var mw2 = mw.Clone())
                {
                    mw2.AutoGammaImage();
                    Write(mw2, "night_AutoGammaImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AutoLevelImage();
                    Write(mw2, "night_AutoLevelImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.LinearStretchImage(2, 98);
                    Write(mw2, "night_LinearStretchImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.NormalizeImage();
                    Write(mw2, "night_NormalizeImage.jpg");
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact(Skip="temp")]
        [Trait("area", "wrap")]
        public void TestBasicWandMethods()
        {
            MagickWandEnvironment.Genesis();
            
            using(var pw = new PixelWand())
            using(var mw = new MagickWand("test.jpg"))
            {
                pw.Red = 200;
                
                using(var mw2 = mw.Clone())
                {
                    mw2.AdaptiveBlurImage(5, 2);
                    Write(mw2, "AdaptiveBlurImage.jpg");
                }
                
                using(var mw2 = mw.Clone())
                {
                    mw2.AdaptiveResizeImage(320, 212);
                    Write(mw2, "adaptiveResizeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AdaptiveSharpenImage(20, 12);
                    Write(mw2, "AdaptiveSharpenImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AdaptiveThresholdImage(20, 12, 2);
                    Write(mw2, "AdaptiveThresholdImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AddNoiseImage(NoiseType.PoissonNoise);
                    Write(mw2, "AddNoiseImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AutoGammaImage();
                    Write(mw2, "AutoGammaImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AutoLevelImage();
                    Write(mw2, "AutoLevelImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.AutoOrientImage();
                    Write(mw2, "AutoOrientImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.BlurImage(10, 2);
                    Write(mw2, "BlurImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.BorderImage(pw, 10, 10);
                    Write(mw2, "BorderImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.BrightnessContrastImage(30, 20);
                    Write(mw2, "BrightnessContrastImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.CharcoalImage(30, 20);
                    Write(mw2, "CharcoalImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ChopImage(30, 20, 0, 0);
                    Write(mw2, "ChopImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ClampImage();
                    Write(mw2, "ClampImage.jpg");
                }
                /*
                using(var mw2 = mw.Clone())
                {
                    mw2.ClipImage();
                    Write(mw2, "ClipImage.jpg");
                }
                */
                using(var mw2 = mw.Clone())
                {
                    mw2.ContrastImage(true);
                    Write(mw2, "ContrastImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ContrastStretchImage(2, 98);
                    Write(mw2, "ContrastStretchImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.CropImage(30, 20, 0, 0);
                    Write(mw2, "CropImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.CycleColormapImage(4);
                    Write(mw2, "CycleColormapImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.DeskewImage(40);
                    Write(mw2, "DeskewImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.DespeckleImage();
                    Write(mw2, "DespeckleImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.EdgeImage(2);
                    Write(mw2, "EdgeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.EmbossImage(12, 2);
                    Write(mw2, "EmbossImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.EnhanceImage();
                    Write(mw2, "EnhanceImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.EqualizeImage();
                    Write(mw2, "EqualizeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.EvaluateImage(MagickEvaluateOperator.CosineEvaluateOperator, 4);
                    Write(mw2, "EvaluateImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ExtentImage(5, 5, 0, 0);
                    Write(mw2, "ExtentImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.FlipImage();
                    Write(mw2, "FlipImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.FlopImage();
                    Write(mw2, "FlopImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.FrameImage(pw, 10, 10, 4, 4);
                    Write(mw2, "FrameImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.GammaImage(3);
                    Write(mw2, "GammaImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.GaussianBlurImage(12, 3);
                    Write(mw2, "GaussianBlurImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ImplodeImage(12);
                    Write(mw2, "ImplodeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.LevelImage(2, 2.3, 98);
                    Write(mw2, "LevelImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.LinearStretchImage(2, 98);
                    Write(mw2, "LinearStretchImage.jpg");
                }
                /*
                using(var mw2 = mw.Clone())
                {
                    mw2.LiquidRescaleImage(320, 212, 2, 2);
                    Write(mw2, "LiquidRescaleImage.jpg");
                }
                */
                using(var mw2 = mw.Clone())
                {
                    mw2.LocalContrastImage(8, 4);
                    Write(mw2, "LocalContrastImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.MagnifyImage();
                    Write(mw2, "MagnifyImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.MinifyImage();
                    Write(mw2, "MinifyImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ModulateImage(2, 3, 4);
                    Write(mw2, "ModulateImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.MotionBlurImage(12, 3, 45);
                    Write(mw2, "MotionBlurImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.NegateImage(true);
                    Write(mw2, "NegateImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.NormalizeImage();
                    Write(mw2, "NormalizeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.OilPaintImage(8);
                    Write(mw2, "OilPaintImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.OptimizeImageTransparency();
                    Write(mw2, "OptimizeImageTransparency.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.PosterizeImage(64, true);
                    Write(mw2, "PosterizeImage.jpg");
                }
                /*
                using(var mw2 = mw.Clone())
                {
                    mw2.ProfileImage();
                    Write(mw2, "ProfileImage.jpg");
                }
                */
                using(var mw2 = mw.Clone())
                {
                    mw2.QuantizeImage(64, ColorspaceType.sRGBColorspace, 12, true, false);
                    Write(mw2, "QuantizeImage.jpg");
                }
                /*
                using(var mw2 = mw.Clone())
                {
                    mw2.RaiseImage(320, 212, 4, 4, true);
                    Write(mw2, "RaiseImage.jpg");
                }
                */
                using(var mw2 = mw.Clone())
                {
                    mw2.RandomThresholdImage(5, 80);
                    Write(mw2, "RandomThresholdImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ResampleImage(96, 96, FilterTypes.Lanczos2SharpFilter, 1);
                    Write(mw2, "ResampleImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ResizeImage(320, 212, FilterTypes.Lanczos2Filter, 2);
                    Write(mw2, "ResizeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.RollImage(4, 4);
                    Write(mw2, "RollImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.RotateImage(pw, 45);
                    Write(mw2, "RotateImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.RotationalBlurImage(45);
                    Write(mw2, "RotationalBlurImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SampleImage(320, 212);
                    Write(mw2, "SampleImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ScaleImage(320, 212);
                    Write(mw2, "ScaleImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SegmentImage(ColorspaceType.sRGBColorspace, false, 5, 2);
                    Write(mw2, "SegmentImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SelectiveBlurImage(8, 2, 4);
                    Write(mw2, "SelectiveBlurImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SepiaToneImage(52428);
                    Write(mw2, "SepiaToneImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ShadeImage(true, 8, 8);
                    Write(mw2, "ShadeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ShadowImage(8, 4, 0, 0);
                    Write(mw2, "ShadowImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SharpenImage(8, 4);
                    Write(mw2, "SharpenImage.jpg");
                }
                /*
                using(var mw2 = mw.Clone())
                {
                    mw2.ShaveImage(320, 212);
                    Write(mw2, "ShaveImage.jpg");
                }
                */
                using(var mw2 = mw.Clone())
                {
                    mw2.ShearImage(pw, 12, 12);
                    Write(mw2, "ShearImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SketchImage(12, 4, 45);
                    Write(mw2, "SketchImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SolarizeImage(5);
                    Write(mw2, "SolarizeImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SpreadImage(5);
                    Write(mw2, "SpreadImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.SwirlImage(5);
                    Write(mw2, "SwirlImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ThresholdImage(5);
                    Write(mw2, "ThresholdImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.ThumbnailImage(320, 212);
                    Write(mw2, "ThumbnailImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.TintImage(pw, pw);
                    Write(mw2, "TintImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.TrimImage(8);
                    Write(mw2, "TrimImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.UnsharpMaskImage(8, 2, 3, 4);
                    Write(mw2, "UnsharpMaskImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.VignetteImage(8, 90, 3, 4);
                    Write(mw2, "VignetteImage.jpg");
                }
                using(var mw2 = mw.Clone())
                {
                    mw2.WaveImage(8, 12);
                    Write(mw2, "WaveImage.jpg");
                }
            }

            MagickWandEnvironment.Terminus();
        }


        [Fact]
        [Trait("area", "wrap")]
        public void StreamTest()
        {
            MagickWandEnvironment.Genesis();
            
            using(var wand = new MagickWand(TestHelper.TEST_FILE))
            using(var ms = new MemoryStream())
            {
                wand.WriteImage(ms);
                
                var streamfile = "streamtest.jpg";
                
                using(var fs = new FileStream(streamfile, FileMode.CreateNew))
                {
                    ms.CopyTo(fs);
                    fs.Flush();
                }
                
                Assert.True(File.Exists(streamfile));
                
                using(var newWand = new MagickWand(streamfile))
                {
                    Assert.True(wand.ImageHeight == newWand.ImageHeight);
                    Assert.True(wand.ImageWidth == newWand.ImageWidth);
                }
                
                File.Delete(streamfile);
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact]
        [Trait("area", "wrap")]
        public void PixelIteratorTest()
        {
            MagickWandEnvironment.Genesis();
            
            using(var wand = new MagickWand(TestHelper.TEST_FILE))
            using(var pit = new PixelIterator(wand))
            {
                var yCount = 0;
                string[,] imgColors = new string[wand.ImageWidth, wand.ImageHeight];
                
                for(int y = 0; y < wand.ImageHeight; y++)
		        {
                    var list = pit.GetNextIteratorRow();

                    Assert.True(list.Count == wand.ImageWidth, "we should get the same number of pixels as the image width");
                    
                    for(int x = 0; x < list.Count; x++)
                    {
                        imgColors[x,y] = list[x].Color;
                    }

                    yCount++;
                }
                
                Assert.True(wand.ImageHeight == yCount, "we should have iterated over all rows in the image successfully");
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact]
        [Trait("area", "wrap")]
        public void PixelHtmlColor()
        {
            MagickWandEnvironment.Genesis();
            
            using(var wand = new MagickWand(TestHelper.TEST_FILE))
            using(var pw = wand.GetImagePixelColor(100, 100))
            {
                Assert.True(string.Equals(pw.HtmlColor, "#5C3A15", StringComparison.OrdinalIgnoreCase));
            }
            
            MagickWandEnvironment.Terminus();
        }
        

        void Write(MagickWand wand, string file)
        {
            if(KEEP_FILES)
            {
                wand.WriteImage("wrapper_out" + Path.DirectorySeparatorChar + file, true);
            }
        }
    }
}
