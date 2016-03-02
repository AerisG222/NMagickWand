using System;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using NMagickWand;


namespace NMagickWand.Tests
{
    public class WrapperTests
    {
        [Fact]
        [Trait("area", "wrap ")]
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
    }
}
