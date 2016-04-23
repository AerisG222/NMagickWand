using System;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using NMagickWand;


namespace NMagickWand.Tests
{
    public class CoreTests
    {
        [Fact]
        [Trait("area", "core")]
        public void GenesisAndTerminus()
        {
            MagickWandApi.MagickWandGenesis();
            
            Assert.True(MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.True, "Environment should be initialized after calling genesis");
            
            MagickWandApi.MagickWandTerminus();
            
            Assert.True(MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.False, "Environment should not be initialized after calling terminus");
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void CreateDestroyWand()
        {
            MagickWandApi.MagickWandGenesis();
            
            var wand = MagickWandApi.NewMagickWand();
            
            Assert.True(wand != null, "New wand should not be null");
            Assert.True(wand != IntPtr.Zero, "New wand should not be equal to IntPtr.Zero");
            Assert.True(MagickWandApi.IsMagickWand(wand) == MagickBooleanType.True, "New wand should be identifiable as a wand");
            
            var anotherWand = MagickWandApi.DestroyMagickWand(wand);
            
            Assert.True(MagickWandApi.IsMagickWand(wand) == MagickBooleanType.False, "Wand should be invalid after destroying");
            Assert.True(MagickWandApi.IsMagickWand(anotherWand) == MagickBooleanType.False, "The other wand should be invalid too");
            Assert.True(wand != anotherWand, "The wands should be different");
            
            MagickWandApi.MagickWandTerminus();
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void ReadImageFromFile()
        {
            MagickWandApi.MagickWandGenesis();
            
            var wand = MagickWandApi.NewMagickWand();
            
            Assert.True(MagickWandApi.MagickReadImage(wand, TestHelper.TEST_FILE) == MagickBooleanType.True, "Read image should succeed");
            
            wand = MagickWandApi.DestroyMagickWand(wand);
            MagickWandApi.MagickWandTerminus();
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void GetImageDimensions()
        {
            var wand = TestHelper.StartTestWithImage();
            
            Assert.True(MagickWandApi.MagickGetImageHeight(wand) == (UIntPtr)425, "Height should be 425");
            Assert.True(MagickWandApi.MagickGetImageWidth(wand) == (UIntPtr)640, "Height should be 640");
            
            TestHelper.EndTestWithImage(wand);
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void SaveImageToFile()
        {
            var wand = TestHelper.StartTestWithImage();
            var tmp = TestHelper.GetTempFilename();
            
            var res = MagickWandApi.MagickWriteImage(wand, tmp);
            var fi = new FileInfo(tmp);
            
            Assert.True(res == MagickBooleanType.True, "ImageMagick should report success writing a file");
            Assert.True(fi.Exists, "Written file should exist");
            Assert.True(fi.Length > 0, "File length should be greater than zero");
            
            TestHelper.EndTestWithImage(wand, fi);
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void ResizeImage()
        {
            var wand = TestHelper.StartTestWithImage();
            var tmp = TestHelper.GetTempFilename();
            
            var height = new UIntPtr(100);
            var width = new UIntPtr(50);
            
            var res = MagickWandApi.MagickScaleImage(wand, width, height);
            
            Assert.True(res == MagickBooleanType.True, "Scaling should report success");
            
            res = MagickWandApi.MagickWriteImage(wand, tmp);
            
            if (res == MagickBooleanType.False)
            {
                throw new InvalidOperationException("did not successfully write the scaled image");
            }
            
            var fi = new FileInfo(tmp);
            var fiOrig = new FileInfo(TestHelper.TEST_FILE);
            
            Assert.True(fiOrig.Length > fi.Length, "The original, larger, image should be bigger");
            
            var newWand = TestHelper.GetWandForFile(tmp);
            
            Assert.True(MagickWandApi.MagickGetImageHeight(wand) == height, "Height should match what it was scaled to");
            Assert.True(MagickWandApi.MagickGetImageWidth(wand) == width, "Width should match what it was scaled to");
            
            MagickWandApi.DestroyMagickWand(newWand);
            
            TestHelper.EndTestWithImage(wand, fi);
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void GetPixelColor()
        {
            var wand = TestHelper.StartTestWithImage();
            var pixelWand = MagickWandApi.NewPixelWand();
            
            Assert.True(pixelWand != null);
            Assert.True(pixelWand != IntPtr.Zero);
            
            var res = MagickWandApi.MagickGetImagePixelColor(wand, (IntPtr)1, (IntPtr)1, pixelWand);
            
            Assert.True(res == MagickBooleanType.True, "Did not get pixel info");
            
            var color = MagickHelper.GetMagickString(MagickWandApi.PixelGetColorAsString(pixelWand));
            
            Assert.True(!string.IsNullOrEmpty(color));
            
            color = MagickHelper.GetMagickString(MagickWandApi.PixelGetColorAsNormalizedString(pixelWand));

            Assert.True(!string.IsNullOrEmpty(color));

            TestHelper.EndTestWithImage(wand);
        }
        
        
        [Fact]
        [Trait("area", "core")]
        public void GetExifInfo()
        {
            UIntPtr count;
            var wand = TestHelper.StartTestWithImage();
            
            var strArrayPtr = MagickWandApi.MagickGetImageProperties(wand, "*", out count);
            var idxPtr = strArrayPtr;
            
            for (int i = 0; i < (int)count; i++)
            {
                idxPtr = IntPtr.Add(idxPtr, i * IntPtr.Size);
                var strPtr = Marshal.ReadIntPtr(idxPtr);
                var str = Marshal.PtrToStringAnsi(strPtr);
                
                // looks like the last property is a null string, so don't include that in the test
                if(i < (int)count - 1)
                {
                    Assert.True(str != null, "property name should not be null");
                }
                
                // free the string value
                MagickWandApi.MagickRelinquishMemory(strPtr);
            }
            
            // free the array
            MagickWandApi.MagickRelinquishMemory(strArrayPtr);
        }
        
        
        [Fact]
        [TraitAttribute("area", "core")]
        public void GetImageMagickInfo()
        {
            MagickWandEnvironment.Genesis();
            
            uint depth;
            
            var d = MagickWandEnvironment.GetQuantumDepth(out depth);
            
            Console.WriteLine("depth: " + depth.ToString());
            Assert.True(!string.IsNullOrWhiteSpace(d), "Quantum Depth should be defined");
            
            var r = MagickWandEnvironment.GetQuantumRange(out depth);
            
            Console.WriteLine("range: " + r);
            Assert.True(!string.IsNullOrWhiteSpace(r), "Quantum Range should be defined");
            
            Console.WriteLine("copyright: " + MagickWandEnvironment.Copyright);
            Assert.True(!string.IsNullOrWhiteSpace(MagickWandEnvironment.Copyright));
            
            Console.WriteLine("homeurl: " + MagickWandEnvironment.HomeUrl);
            Assert.True(!string.IsNullOrWhiteSpace(MagickWandEnvironment.HomeUrl));
            
            Console.WriteLine("package name: " + MagickWandEnvironment.PackageName);
            Assert.True(!string.IsNullOrWhiteSpace(MagickWandEnvironment.PackageName));
            
            uint ver;
            var verStr = MagickWandEnvironment.GetVersion(out ver);
            Console.WriteLine("version: " + verStr + " : " + ver.ToString());
            Assert.True(!string.IsNullOrWhiteSpace(verStr));
            
            MagickWandEnvironment.Terminus();
        }
    }
}