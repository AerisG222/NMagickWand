using System;
using System.IO;
using Xunit;
using NMagickWand.Enums;


namespace NMagickWand.Tests
{
    public class ContrastTests
    {
        const bool KEEP_FILES = false;
        static readonly string[] _files = Directory.GetFiles("contrast_tests");
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void SigmoidalTest()
        {
            double[] alpha = { 1, 2, 3, 4 };
            double[] beta = { 0 , 5000, 20000, 30000, 40000, 65000 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var a in alpha)
                    {
                        foreach(var b in beta)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.SigmoidalContrastImage(true, a, b);
                                
                                WriteImage("sigmoidal", file, new string[] { a.ToString(), b.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
       
        
        [Fact()]
        [Trait("area", "contrast")]
        public void ContrastTest()
        {
            double[] alpha = { 0, .5, 1, 1.1 };
            double[] beta = { 0 , 5000, 20000, 30000, 40000, 65000 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    using(var tmp = wand.Clone())
                    {
                        tmp.ContrastImage(true);
                        
                        WriteImage("contrast", file, new string[] { "1" }, tmp);
                        
                        tmp.ContrastImage(true);
                        
                        WriteImage("contrast", file, new string[] { "2" }, tmp);
                        
                        tmp.ContrastImage(true);
                        
                        WriteImage("contrast", file, new string[] { "3" }, tmp);
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void ContrastStretchTest()
        {
            double[] black = { 0, 100, 1000, 2000 };
            double[] white = { 0, 50000, 60000, 65000 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var b in black)
                    {
                        foreach(var w in white)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.ContrastStretchImage(b, w);
                                
                                WriteImage("contrast_stretch", file, new string[] { b.ToString(), w.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void LevelTest()
        {
            double[] black = { 0, 100, 1000, 2000 };
            double[] white = { 0, 50000, 60000, 65000 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var b in black)
                    {
                        foreach(var w in white)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.LevelImage(b, 1, w);  // 1 = no gamma
                                
                                WriteImage("level", file, new string[] { b.ToString(), w.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void LinearStretchTest()
        {
            double[] black = { 0, 100, 1000, 2000 };
            double[] white = { 0, 50000, 60000, 65000 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var b in black)
                    {
                        foreach(var w in white)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.LinearStretchImage(b, w);
                                
                                WriteImage("linear_stretch", file, new string[] { b.ToString(), w.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void ModulateTest()
        {
            double[] brightness = { 50, 100, 150 };
            double[] saturation = { 0, 100, 120, 150 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var b in brightness)
                    {
                        foreach(var s in saturation)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.ModulateImage(b, s, 300);  // 300 = no rotation
                                
                                WriteImage("modulate", file, new string[] { b.ToString(), s.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void NormalizeTest()
        {
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    wand.NormalizeImage();
                    
                    WriteImage("normalize", file, new string[] { }, wand);
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void BrightnessContrastTest()
        {
            double[] brightness = { 0, 10, 25 };
            double[] contrast = { 0, 10, 25 };
            
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    foreach(var b in brightness)
                    {
                        foreach(var c in contrast)
                        {
                            using(var tmp = wand.Clone())
                            {
                                tmp.BrightnessContrastImage(b, c);
                                
                                WriteImage("brightness_contrast", file, new string[] { b.ToString(), c.ToString() }, tmp);
                            }
                        }
                    }
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "contrast")]
        public void AutoLevelTest()
        {
            MagickWandEnvironment.Genesis();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    wand.AutoLevelImage();
                    
                    WriteImage("auto_level", file, new string[] { }, wand);
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        [Fact()]
        [Trait("area", "composed")]
        public void ComposedTest()
        {
            var contrastRatioThreshold = 0.5;
            var tooContrastyThreshold = 1.9;
            
            MagickWandEnvironment.Genesis();
            
            PrintStatsHeader();
            
            foreach(var file in _files)
            {
                using(var wand = new MagickWand(file))
                {
                    double mean, stddev;
                    
                    wand.GetImageChannelMean(ChannelType.AllChannels, out mean, out stddev);
                    
                    PrintStats(file, wand);
                    
                    wand.AutoLevelImage();
                    
                    var contrastRatio = stddev / mean;
                    var contrastyRatio = stddev / 10000;
                    
                    if(contrastRatio < contrastRatioThreshold)
                    {
                        var saturationAmount = Convert.ToInt32((contrastRatioThreshold - contrastRatio) * 100) * 4;
                        
                        // limit the saturation adjustment to 20%
                        if(saturationAmount > 20)
                        {
                            saturationAmount = 20;
                        }
                        
                        saturationAmount += 100;
                        
                        Console.WriteLine("modulating by: " + saturationAmount);
                        
                        // 100 = don't adjust brightness
                        // 300 = don't rotate hue
                        wand.ModulateImage(100, saturationAmount, 300);
                    }
                    else if(contrastyRatio > tooContrastyThreshold)
                    {
                        Console.WriteLine("attempting to reduce contrast");
                        wand.SigmoidalContrastImage(true, 2, 0);  // smooth brightness/contrast
                    }
                    
                    wand.UnsharpMaskImage(0, 0.7, 0.7, 0.008);  // sharpen
                    
                    WriteImage("composed", file, new string[] { }, wand);
                }
            }
            
            MagickWandEnvironment.Terminus();
        }
        
        
        void PrintStatsHeader()
        {
            Console.WriteLine("File\tMean\tStdDev\tKurtosis\tSkewness");
        }
        
        
        void PrintStats(string file, MagickWand wand)
        {
            double mean, stddev, kurtosis, skewness;
            
            wand.GetImageChannelMean(ChannelType.AllChannels, out mean, out stddev);
            wand.GetImageChannelKurtosis(ChannelType.AllChannels, out kurtosis, out skewness);
            
            Console.WriteLine($"{Path.GetFileName(file)}\t{mean}\t{stddev}\t{kurtosis}\t{skewness}");
        }
        
        
        void WriteImage(string test, string filename, string[] args, MagickWand wand)
        {
            var dir = Path.Combine("contrast_tests", test);
            var file = $"{Path.GetFileNameWithoutExtension(filename)}_{string.Join("_", args)}{Path.GetExtension(filename)}";
            var fullPath = Path.Combine(dir, file);
            
            Directory.CreateDirectory(dir);
            wand.WriteImage(fullPath, true);
        }
    }
}
