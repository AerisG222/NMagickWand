using System;
using System.Collections.Generic;
using System.Linq;


namespace NMagickWand
{
    public class PixelWand
        : IDisposable
    {
        internal bool FreeOnDispose { get; set; }
        internal IntPtr Wand { get; set; }


        public double Alpha
        {
            get
            {
                return MagickWandApi.PixelGetAlpha(Wand);
            }
            set
            {
                MagickWandApi.PixelSetAlpha(Wand, value);
            }
        }


        public string AlphaHtml
        {
            get
            {
                return ToHtml(Alpha);
            }
        }
        

        public float AlphaQuantum
        {
            get
            {
                return MagickWandApi.PixelGetAlphaQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetAlphaQuantum(Wand, value);
            }
        }


        public double Black
        {
            get
            {
                return MagickWandApi.PixelGetBlack(Wand);
            }
            set
            {
                MagickWandApi.PixelSetBlack(Wand, value);
            }
        }


        public float BlackQuantum
        {
            get
            {
                return MagickWandApi.PixelGetBlackQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetBlackQuantum(Wand, value);
            }
        }


        public double Blue
        {
            get
            {
                return MagickWandApi.PixelGetBlue(Wand);
            }
            set
            {
                MagickWandApi.PixelSetBlue(Wand, value);
            }
        }


        public string BlueHtml
        {
            get
            {
                return ToHtml(Blue);
            }
        }
        
        
        public float BlueQuantum
        {
            get
            {
                return MagickWandApi.PixelGetBlueQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetBlueQuantum(Wand, value);
            }
        }


        public string Color
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.PixelGetColorAsString(Wand));
            }
            set
            {
                Check(MagickWandApi.PixelSetColor(Wand, value));
            }
        }


        public string NormalizedColor
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.PixelGetColorAsNormalizedString(Wand));
            }
        }
        
        
        public string HtmlColor
        {
            get
            {
                return $"#{RedHtml}{GreenHtml}{BlueHtml}";
            }
        }


        public uint ColorCount
        {
            get
            {
                return (uint)MagickWandApi.PixelGetColorCount(Wand);
            }
            set
            {
                MagickWandApi.PixelSetColorCount(Wand, (UIntPtr)value);
            }
        }


        public double Cyan
        {
            get
            {
                return MagickWandApi.PixelGetCyan(Wand);
            }
            set
            {
                MagickWandApi.PixelSetCyan(Wand, value);
            }
        }


        public float CyanQuantum
        {
            get
            {
                return MagickWandApi.PixelGetCyanQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetCyanQuantum(Wand, value);
            }
        }


        public double Fuzz
        {
            get
            {
                return MagickWandApi.PixelGetFuzz(Wand);
            }
            set
            {
                MagickWandApi.PixelSetFuzz(Wand, value);
            }
        }


        public double Green
        {
            get
            {
                return MagickWandApi.PixelGetGreen(Wand);
            }
            set
            {
                MagickWandApi.PixelSetGreen(Wand, value);
            }
        }


        public string GreenHtml
        {
            get
            {
                return ToHtml(Green);
            }
        }
        

        public float GreenQuantum
        {
            get
            {
                return MagickWandApi.PixelGetGreenQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetGreenQuantum(Wand, value);
            }
        }


        public float Index
        {
            get
            {
                return MagickWandApi.PixelGetIndex(Wand);
            }
            set
            {
                MagickWandApi.PixelSetIndex(Wand, value);
            }
        }


        public bool IsPixelWand
        {
            get
            {
                return MagickWandApi.IsPixelWand(Wand) == MagickBooleanType.True;
            }
        }


        public double Magenta
        {
            get
            {
                return MagickWandApi.PixelGetMagenta(Wand);
            }
            set
            {
                MagickWandApi.PixelSetMagenta(Wand, value);
            }
        }


        public float MagentaQuantum
        {
            get
            {
                return MagickWandApi.PixelGetMagentaQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetMagentaQuantum(Wand, value);
            }
        }


        public double Opacity
        {
            get
            {
                return MagickWandApi.PixelGetOpacity(Wand);
            }
            set
            {
                MagickWandApi.PixelSetOpacity(Wand, value);
            }
        }


        public float OpacityQuantum
        {
            get
            {
                return MagickWandApi.PixelGetOpacityQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetOpacityQuantum(Wand, value);
            }
        }


        public double Red
        {
            get
            {
                return MagickWandApi.PixelGetRed(Wand);
            }
            set
            {
                MagickWandApi.PixelSetRed(Wand, value);
            }
        }
        
        
        public string RedHtml
        {
            get
            {
                return ToHtml(Red);
            }
        }


        public float RedQuantum
        {
            get
            {
                return MagickWandApi.PixelGetRedQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetRedQuantum(Wand, value);
            }
        }


        public double Yellow
        {
            get
            {
                return MagickWandApi.PixelGetYellow(Wand);
            }
            set
            {
                MagickWandApi.PixelSetYellow(Wand, value);
            }
        }


        public float YellowQuantum
        {
            get
            {
                return MagickWandApi.PixelGetYellowQuantum(Wand);
            }
            set
            {
                MagickWandApi.PixelSetYellowQuantum(Wand, value);
            }
        }


        public PixelWand()
        {
            Wand = MagickWandApi.NewPixelWand();
            FreeOnDispose = true;
        }


        internal PixelWand(IntPtr pixelWand)
            : this(pixelWand, true)
        {
            
        }


        internal PixelWand(IntPtr pixelWand, bool freeOnDispose)
        {
            Wand = pixelWand;
            FreeOnDispose = freeOnDispose;
        }
        

        public void Clear()
        {
            MagickWandApi.ClearPixelWand(Wand);
        }


        public PixelWand Clone()
        {
            return new PixelWand(MagickWandApi.ClonePixelWand(Wand));
        }


        public IReadOnlyList<PixelWand> Clone(IReadOnlyList<PixelWand> wands)
        {
            var wandArray = wands.Select(x => x.Wand).ToArray();
            var arr = MagickWandApi.ClonePixelWands(wandArray[0], (UIntPtr)wandArray.Length);
            
            return MagickHelper.GetMagickPixelWandList(arr, (UIntPtr)wands.Count);
        }


        public void GetHSL(out double hue, out double saturation, out double lightness)
        {
            MagickWandApi.PixelGetHSL(Wand, out hue, out saturation, out lightness);
        }


        public PixelPacket GetMagickColor()
        {
            var pp = new PixelPacket();
            MagickWandApi.PixelGetMagickColor(Wand, ref pp);

            return pp;
        }


        public PixelPacket GetQuantumColor()
        {
            var pp = new PixelPacket();
            MagickWandApi.PixelGetQuantumColor(Wand, ref pp);

            return pp;
        }


        public bool IsSimilar(PixelWand referenceWand, double fuzz)
        {
            return MagickWandApi.IsPixelWandSimilar(Wand, referenceWand.Wand, fuzz) == MagickBooleanType.True;
        }


        public void SetColorFromWand(PixelWand color)
        {
            MagickWandApi.PixelSetColorFromWand(Wand, color.Wand);
        }


        public void SetHSL(double hue, double saturation, double lightness)
        {
            MagickWandApi.PixelSetHSL(Wand, hue, saturation, lightness);
        }


        public void SetMagickColor(PixelPacket color)
        {
            MagickWandApi.PixelSetMagickColor(Wand, ref color);
        }


        public void SetQuantumColor(PixelPacket color)
        {
            MagickWandApi.PixelSetQuantumColor(Wand, ref color);
        }


        string ToHtml(double normalizedValue)
        {
            return ((int)(normalizedValue * 255)).ToString("X2");
        }
        
        
        void Check(MagickBooleanType result)
        {
            if(result == MagickBooleanType.False)
            {
                CheckAndRaiseException();
            }
        }


        void CheckAndRaiseException()
        {
            var exType = ExceptionType.UndefinedException;
            var msgPtr = MagickWandApi.PixelGetException(Wand, ref exType);

            if(exType != ExceptionType.UndefinedException)
            {
                var msg = MagickHelper.GetMagickString(msgPtr);

                MagickWandApi.MagickRelinquishMemory(msgPtr);
                MagickWandApi.PixelClearException(Wand);

                throw new MagickWandException(exType, msg);
            }
        }


        ~PixelWand()
        {
            Dispose(false);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                // free managed objects
            }

            // free native objects
            if(Wand != IntPtr.Zero && FreeOnDispose)
            {
                MagickWandApi.DestroyPixelWand(Wand);

                Wand = IntPtr.Zero;
            }
        }
    }
}
