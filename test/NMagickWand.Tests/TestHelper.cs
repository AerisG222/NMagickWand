using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using NMagickWand;
using NMagickWand.Enums;


namespace NMagickWand.Tests
{
    public static class TestHelper
    {
        public const string TEST_FILE = "test.jpg";
        
        
        public static bool Mogrify(string args) {
            var psi = new ProcessStartInfo();
            psi.FileName = "mogrify";
            psi.Arguments = args;
            
            using(var p = Process.Start(psi))
            {
                return p.WaitForExit(12000);
            }
        }
        
        
        public static string ComputeHash(string filename)
        {
            using(var stream = new FileStream(filename, FileMode.Open))
            {
                return TestHelper.ComputeHash(stream);
            }
        }
        
        
        public static string ComputeHash(Stream buffer)
        {
            using(var cryptoProvider = new SHA1CryptoServiceProvider())
            {
                return BitConverter.ToString(cryptoProvider.ComputeHash(buffer));
            }
        }
        
        
        public static IntPtr StartTestWithImage()
        {
            if(MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.False)
            {
                MagickWandApi.MagickWandGenesis();
            }
            
            return TestHelper.GetWandForFile(TestHelper.TEST_FILE);
        }
        
        
        public static void EndTestWithImage(IntPtr wand) 
        {
            EndTestWithImage(wand, null);
        }
        
        
        public static void EndTestWithImage(IntPtr wand, FileInfo tempFile) 
        {
            MagickWandApi.DestroyMagickWand(wand);
            MagickWandApi.MagickWandTerminus();
            
            if(tempFile != null && tempFile.Exists)
            {
                tempFile.Delete();
            }
        }
        
        
        public static string GetTempFilename()
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(TEST_FILE);
        }
        
        
        public static IntPtr GetWandForFile(string filename)
        {
            var wand = MagickWandApi.NewMagickWand();
            var res = MagickWandApi.MagickReadImage(wand, filename);
            
            if (res == MagickBooleanType.False)
            {
                throw new InvalidOperationException("Unable to open image: " + filename);
            }
            
            return wand;
        }
    }
}
