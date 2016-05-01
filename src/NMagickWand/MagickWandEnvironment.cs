using System;
using System.Collections.Generic;
using NMagickWand.Enums;


namespace NMagickWand
{
    public static class MagickWandEnvironment
    {
        public static string Copyright
        {
            get
            {
                return MagickHelper.GetMagickConstString(MagickWandApi.MagickGetCopyright());
            }
        }


        public static string HomeUrl
        {
            get
            {
                return MagickHelper.GetMagickConstString(MagickWandApi.MagickGetHomeURL());
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
                return MagickHelper.GetMagickConstString(MagickWandApi.MagickGetPackageName());
            }
        }

        
        public static uint QuantumDepth
        {
            get
            {
                uint depth;
                
                GetQuantumDepth(out depth);
                
                return depth;
            }
        }
        
        
        public static string QuantumDepthDescription
        {
            get
            {
                uint depth;
                
                return GetQuantumDepth(out depth);
            }
        }
        
        
        public static uint QuantumRange
        {
            get
            {
                uint range;
                
                GetQuantumRange(out range);
                
                return range;
            }
        }
        
        
        public static string QuantumRangeDescription
        {
            get
            {
                uint range;
                
                return GetQuantumRange(out range);
            }
        }
        

        public static string ReleaseDate
        {
            get
            {
                return MagickHelper.GetMagickConstString(MagickWandApi.MagickGetReleaseDate());
            }
        }
        
        
        public static uint Version
        {
            get
            {
                uint version;
                
                GetVersion(out version);
                
                return version;
            }
        }
        
        
        public static string VersionDescription
        {
            get
            {
                uint version;
                
                return GetVersion(out version);
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


        public static uint GetResource(ResourceType type)
        {
            return (uint) MagickWandApi.MagickGetResource(type);
        }


        public static uint GetResourceLimit(ResourceType type)
        {
            return (uint) MagickWandApi.MagickGetResourceLimit(type);
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
        
        
        static string GetQuantumDepth(out uint depth)
        {
            UIntPtr d;

            var ptr = MagickWandApi.MagickGetQuantumDepth(out d);

            depth = (uint)d;

            return MagickHelper.GetMagickConstString(ptr);
        }


        static string GetQuantumRange(out uint depth)
        {
            UIntPtr d;

            var ptr = MagickWandApi.MagickGetQuantumRange(out d);

            depth = (uint)d;

            return MagickHelper.GetMagickConstString(ptr);
        }
        
        
        static string GetVersion(out uint version)
        {
            UIntPtr v;

            var ptr = MagickWandApi.MagickGetVersion(out v);

            version = (uint)v;

            return MagickHelper.GetMagickConstString(ptr);
        }
    }
}
