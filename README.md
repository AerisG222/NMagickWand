[![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/AerisG222/NMagickWand/blob/master/LICENSE.md)
[![NuGet](https://buildstats.info/nuget/NMagickWand)](https://www.nuget.org/packages/NMagickWand/)
[![Travis](https://img.shields.io/travis/AerisG222/NMagickWand.svg?maxAge=2592000)](https://travis-ci.org/AerisG222/NMagickWand)
[![Coverity Scan](https://img.shields.io/coverity/scan/7995.svg)](https://scan.coverity.com/projects/aerisg222-nmagickwand)

# NMagickWand

A .Net library to expose the MagickWand API from ImageMagick.

## Motivation
I am trying to move my personal projects to .Net Core, and the
graphics support is not there right now.  While there are lots
of conversations happening about how to address this, I have
not found working code that looks particularly compelling.

## Using - Wrapped
```csharp
using NMagickWand;

namespace Test
{
    public class WrapperExample
    {
        public void MakeThumbnail()
        {
            MagickWandEnvironment.Genesis();

            using(var mw = new MagickWand("test.jpg"))
            {
                mw.ScaleImage(120, 120);
                mw.WriteImage("test2.jpg");
            }

            MagickWandEnvironment.Terminus();
        }
    }
}
```

## Using - Unwrapped
- Install ImageMagick (currently targets v6)
- Add a reference to NMagickWand in your project.json
- Bring down the packages for your project via `dnu restore`


```csharp
using NMagickWand;

namespace Test
{
    public class Example
    {
        public void MakeThumbnail(string srcFilename, string destFilename)
        {
            MagickWandApi.MagickWandGenesis();

            var wand = MagickWandApi.NewMagickWand();
            MagickWandApi.MagickReadImage(wand, srcFilename);
            MagickWandApi.MagickScaleImage(wand, (UIntPtr)120, (UIntPtr)120);
            MagickWandApi.MagickWriteImage(wand, destFilename);

            MagickWandApi.MagickWandTerminus();
        }
    }
}
```

- View the tests for more examples

## Developing
This library was built by starting with scripting out the
API calls, and then filling in types where needed (mostly enums).
The first step of the process is to run `tools/genapi` - this
currently runs in bash with awk.  While I've tested this only
on Linux, I hope it would run pretty cleanly elsewhere.

This tool will overwrite the src/NMagickWand/MagickWandApi_.cs file
based on how it parses the header files that come with the development
ImageMagick package.

From there, different types and enums were populated by hand.

## Contributing
I'm happy to accept pull requests.  By submitting a pull request, you
must be the original author of code, and must not be breaking
any laws or contracts.

Otherwise, if you have comments, questions, or complaints, please file
issues to this project on the github repo.

## Todo
I hope to make many improvements to the library as time permits.
- update target frameworks for .net core
- Investigate options to bundle a statically compiled version of the library
  to simplify steps needed to use this.

## License
NMagickWand is licensed under the MIT license.  See LICENSE.md for more
information.

## Reference
- ImageMagick: http://imagemagick.org/
- ImageMagick License: http://www.imagemagick.org/script/license.php
