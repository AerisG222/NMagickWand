using System;
using System.IO;
using Xunit;
using NMagickWand;


namespace NMagickWand.Tests
{
    public class CoreTests
    {
        [Fact]
        public void GenesisAndTerminus()
        {
            MagickWandApi.MagickWandGenesis();
            
            Assert.True(MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.True, "Environment should be initialized after calling genesis");
            
            MagickWandApi.MagickWandTerminus();
            
            Assert.True(MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.False, "Environment should not be initialized after calling terminus");
        }
        
        
        [Fact]
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
        public void ReadImageFromFile()
        {
            MagickWandApi.MagickWandGenesis();
            
            var wand = MagickWandApi.NewMagickWand();
            
            Assert.True(MagickWandApi.MagickReadImage(wand, TestHelper.TEST_FILE) == MagickBooleanType.True, "Read image should succeed");
            
            wand = MagickWandApi.DestroyMagickWand(wand);
            MagickWandApi.MagickWandTerminus();
        }
        
        
        [Fact]
        public void GetImageDimensions()
        {
            var wand = TestHelper.StartTestWithImage();
            
            Assert.True(MagickWandApi.MagickGetImageHeight(wand) == (UIntPtr)425, "Height should be 425");
            Assert.True(MagickWandApi.MagickGetImageWidth(wand) == (UIntPtr)640, "Height should be 640");
            
            TestHelper.EndTestWithImage(wand);
        }
        
        
        [Fact]
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
        public void ResizeImage()
        {
            var wand = TestHelper.StartTestWithImage();
            var tmp = TestHelper.GetTempFilename();
            
            var res = MagickWandApi.MagickScaleImage(wand, (UIntPtr)10, (UIntPtr)10);
            
            Assert.True(res == MagickBooleanType.True, "Scaling should report success");
            
            res = MagickWandApi.MagickWriteImage(wand, tmp);
            
            if (res == MagickBooleanType.False)
            {
                throw new InvalidOperationException("did not successfully write the scaled image");
            }
            
            var fi = new FileInfo(tmp);
            var fiOrig = new FileInfo(TestHelper.TEST_FILE);
            
            Assert.True(fiOrig.Length > fi.Length, "The original, larger, image should be bigger");
            
            TestHelper.EndTestWithImage(wand, fi);
        }
    }
}