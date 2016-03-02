using System;
using System.Collections.Generic;


namespace NMagickWand
{
    public static class MagickWandEnvironment
    {
        public static string Copyright
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetCopyright());
            }
        }


        public static string HomeUrl
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetHomeURL());
            }
        }


        public static bool IsInstantiated
        {
            get
            {
                return MagickWandApi.IsMagickWandInstantiated() == MagickBooleanType.True;
            }
        }


        public static string PackageName
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetPackageName());
            }
        }


        public static string ReleaseDate
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetReleaseDate());
            }
        }


        public static void Genesis()
        {
            MagickWandApi.MagickWandGenesis();
        }


        public static void Terminus()
        {
            MagickWandApi.MagickWandTerminus();
        }


        public static string GetQuantumDepth(out uint depth)
        {
            UIntPtr d;

            var ptr = MagickWandApi.MagickGetQuantumDepth(out d);

            depth = (uint)d;

            return MagickHelper.GetMagickString(ptr);
        }


        public static string GetQuantumRange(out uint depth)
        {
            UIntPtr d;

            var ptr = MagickWandApi.MagickGetQuantumRange(out d);

            depth = (uint)d;

            return MagickHelper.GetMagickString(ptr);
        }


        public static uint GetResource(ResourceType type)
        {
            return (uint) MagickWandApi.MagickGetResource(type);
        }


        public static uint GetResourceLimit(ResourceType type)
        {
            return (uint) MagickWandApi.MagickGetResourceLimit(type);
        }


        public static string GetVersion(out uint version)
        {
            UIntPtr v;

            var ptr = MagickWandApi.MagickGetVersion(out v);

            version = (uint)v;

            return MagickHelper.GetMagickString(ptr);
        }


        public static string QueryConfigureOption(string option)
        {
            return MagickHelper.GetMagickString(MagickWandApi.MagickQueryConfigureOption(option));
        }


        public static IReadOnlyCollection<string> QueryConfigureOptions(string pattern)
        {
            return MagickHelper.ExecuteMagickQueryStringList(pattern, MagickWandApi.MagickQueryConfigureOptions);
        }


        public static IReadOnlyCollection<string> QueryFonts(string pattern)
        {
            return MagickHelper.ExecuteMagickQueryStringList(pattern, MagickWandApi.MagickQueryFonts);
        }


        public static IReadOnlyCollection<string> QueryFormats(string pattern)
        {
            return MagickHelper.ExecuteMagickQueryStringList(pattern, MagickWandApi.MagickQueryFormats);
        }
    }
}
