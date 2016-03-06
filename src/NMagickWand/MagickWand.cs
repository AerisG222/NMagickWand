using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;


namespace NMagickWand
{
    public class MagickWand
            : IDisposable
    {
        long _memPressure;


        internal IntPtr Wand { get; set; }


        public bool Antialias
        {
            get
            {
                return MagickWandApi.MagickGetAntialias(Wand) == MagickBooleanType.True;
            }
            set
            {
                Check(MagickWandApi.MagickSetAntialias(Wand, ConvertBoolean(value)));
            }
        }


        public PixelWand BackgroundColor
        {
            get
            {
                return new PixelWand(MagickWandApi.MagickGetBackgroundColor(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetBackgroundColor(Wand, value.Wand));
            }
        }


        public ColorspaceType Colorspace
        {
            get
            {
                return MagickWandApi.MagickGetColorspace(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetColorspace(Wand, value));
            }
        }


        public CompressionType Compression
        {
            get
            {
                return MagickWandApi.MagickGetCompression(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetCompression(Wand, value));
            }
        }


        public uint CompressionQuality
        {
            get
            {
                return (uint)MagickWandApi.MagickGetCompressionQuality(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetCompressionQuality(Wand, (UIntPtr)value));
            }
        }


        public uint Depth
        {
            set
            {
                Check(MagickWandApi.MagickSetDepth(Wand, (UIntPtr)value));
            }
        }


        public string Extract
        {
            set
            {
                Check(MagickWandApi.MagickSetExtract(Wand, value));
            }
        }


        public string Filename
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetFilename(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetFilename(Wand, value));
            }
        }


        public string Font
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetFont(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetFont(Wand, value));
            }
        }


        public string Format
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetFormat(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetFormat(Wand, value));
            }
        }


        public GravityType Gravity
        {
            get
            {
                return MagickWandApi.MagickGetGravity(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetGravity(Wand, value));
            }
        }


        public bool HasNextImage
        {
            get
            {
                return MagickWandApi.MagickHasNextImage(Wand) == MagickBooleanType.True;
            }
        }


        public bool HasPreviousImage
        {
            get
            {
                return MagickWandApi.MagickHasPreviousImage(Wand) == MagickBooleanType.True;
            }
        }


        public string IdentifyImage
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickIdentifyImage(Wand));
            }
        }


        public bool ImageAlphaChannel
        {
            get
            {
                return MagickWandApi.MagickGetImageAlphaChannel(Wand) == MagickBooleanType.True;
            }
        }


        public PixelWand ImageBackgroundColor
        {
            get
            {
                var pw = new PixelWand();

                Check(MagickWandApi.MagickGetImageBackgroundColor(Wand, pw.Wand));

                return pw;
            }
            set
            {
                Check(MagickWandApi.MagickSetBackgroundColor(Wand, value.Wand));
            }
        }


        public PixelWand ImageBorderColor
        {
            get
            {
                var pw = new PixelWand();

                Check(MagickWandApi.MagickGetImageBorderColor(Wand, pw.Wand));

                return pw;
            }
            set
            {
                Check(MagickWandApi.MagickSetImageBorderColor(Wand, value.Wand));
            }
        }


        public uint ImageColors
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageColors(Wand);
            }
        }


        public ColorspaceType ImageColorspace
        {
            get
            {
                return MagickWandApi.MagickGetImageColorspace(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageColorspace(Wand, value));
            }
        }


        public CompositeOperator ImageCompose
        {
            get
            {
                return MagickWandApi.MagickGetImageCompose(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageCompose(Wand, value));
            }
        }


        public CompressionType ImageCompression
        {
            get
            {
                return MagickWandApi.MagickGetImageCompression(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageCompression(Wand, value));
            }
        }


        public uint ImageCompressionQuality
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageCompressionQuality(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageCompressionQuality(Wand, (UIntPtr)value));
            }
        }


        public uint ImageDelay
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageDelay(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageDelay(Wand, (UIntPtr)value));
            }
        }


        public uint ImageDepth
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageDepth(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageDepth(Wand, (UIntPtr)value));
            }
        }


        public DisposeType ImageDispose
        {
            get
            {
                return MagickWandApi.MagickGetImageDispose(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageDispose(Wand, value));
            }
        }


        public EndianType ImageEndian
        {
            get
            {
                return MagickWandApi.MagickGetImageEndian(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageEndian(Wand, value));
            }
        }


        public string ImageFilename
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetImageFilename(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetImageFilename(Wand, value));
            }
        }


        public string ImageFormat
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetImageFormat(Wand));
            }
            set
            {
                Check(MagickWandApi.MagickSetImageFormat(Wand, value));
            }
        }


        public double ImageFuzz
        {
            get
            {
                return MagickWandApi.MagickGetImageFuzz(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageFuzz(Wand, value));
            }
        }


        public double ImageGamma
        {
            get
            {
                return MagickWandApi.MagickGetImageGamma(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageGamma(Wand, value));
            }
        }


        public GravityType ImageGravity
        {
            get
            {
                return MagickWandApi.MagickGetImageGravity(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageGravity(Wand, value));
            }
        }


        public uint ImageHeight
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageHeight(Wand);
            }
        }


        public InterlaceType ImageInterlaceScheme
        {
            get
            {
                return MagickWandApi.MagickGetImageInterlaceScheme(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageInterlaceScheme(Wand, value));
            }
        }


        public InterpolatePixelMethod ImageInterpolateMethod
        {
            get
            {
                return MagickWandApi.MagickGetImageInterpolateMethod(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageInterpolateMethod(Wand, value));
            }
        }


        public uint ImageIterations
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageIterations(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageIterations(Wand, (UIntPtr)value));
            }
        }


        public uint ImageLength
        {
            get
            {
                UIntPtr len;

                Check(MagickWandApi.MagickGetImageLength(Wand, out len));

                return (uint)len;
            }
        }


        public PixelWand ImageMatteColor
        {
            get
            {
                PixelWand pw = new PixelWand();

                Check(MagickWandApi.MagickGetImageMatteColor(Wand, pw.Wand));

                return pw;
            }
            set
            {
                Check(MagickWandApi.MagickSetImageMatteColor(Wand, value.Wand));
            }
        }


        public OrientationType ImageOrientation
        {
            get
            {
                return MagickWandApi.MagickGetImageOrientation(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageOrientation(Wand, value));
            }
        }


        public RenderingIntent ImageRenderingIntent
        {
            get
            {
                return MagickWandApi.MagickGetImageRenderingIntent(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageRenderingIntent(Wand, value));
            }
        }


        public uint ImageScene
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageScene(Wand);
            }
            set
            {
                MagickWandApi.MagickSetImageScene(Wand, (UIntPtr)value);
            }
        }


        public string ImageSignature
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.MagickGetImageSignature(Wand));
            }
        }


        public int ImageTicksPerSecond
        {
            get
            {
                return (int)MagickWandApi.MagickGetImageTicksPerSecond(Wand);
            }
            set
            {
                MagickWandApi.MagickSetImageTicksPerSecond(Wand, (IntPtr)value);
            }
        }


        public double ImageTotalInkDensity
        {
            get
            {
                return MagickWandApi.MagickGetImageTotalInkDensity(Wand);
            }
        }


        public ImageType ImageType
        {
            get
            {
                return MagickWandApi.MagickGetImageType(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetImageType(Wand, value));
            }
        }


        public ResolutionType ImageUnits
        {
            get
            {
                return MagickWandApi.MagickGetImageUnits(Wand);
            }
            set
            {
                MagickWandApi.MagickSetImageUnits(Wand, value);
            }
        }


        public VirtualPixelMethod ImageVirtualPixelMethod
        {
            get
            {
                return MagickWandApi.MagickGetImageVirtualPixelMethod(Wand);
            }
            set
            {
                MagickWandApi.MagickSetImageVirtualPixelMethod(Wand, value);
            }
        }


        public uint ImageWidth
        {
            get
            {
                return (uint)MagickWandApi.MagickGetImageWidth(Wand);
            }
        }


        public InterlaceType InterlaceScheme
        {
            get
            {
                return MagickWandApi.MagickGetInterlaceScheme(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetInterlaceScheme(Wand, value));
            }
        }


        public InterpolatePixelMethod InterpolateMethod
        {
            get
            {
                return MagickWandApi.MagickGetInterpolateMethod(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetInterpolateMethod(Wand, value));
            }
        }


        bool IsMagickWand
        {
            get
            {
                return MagickWandApi.IsMagickWand(Wand) == MagickBooleanType.True;
            }
        }


        public int IteratorIndex
        {
            get
            {
                return (int)MagickWandApi.MagickGetIteratorIndex(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetIteratorIndex(Wand, (IntPtr)value));
            }
        }


        public uint NumberImages
        {
            get
            {
                return (uint)MagickWandApi.MagickGetNumberImages(Wand);
            }
        }


        public OrientationType Orientation
        {
            get
            {
                return MagickWandApi.MagickGetOrientation(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetOrientation(Wand, value));
            }
        }


        public double PointSize
        {
            get
            {
                return MagickWandApi.MagickGetPointsize(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetPointsize(Wand, value));
            }
        }


        public IReadOnlyList<double> SamplingFactors
        {
            get
            {
                return MagickHelper.ExecuteMagickWandDoubleList(Wand, MagickWandApi.MagickGetSamplingFactors);
            }
            set
            {
                if(value == null || value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                Check(MagickWandApi.MagickSetSamplingFactors(Wand, (UIntPtr)value.Count, value.ToArray()));
            }
        }


        public int SizeOffset
        {
            get
            {
                IntPtr size;

                Check(MagickWandApi.MagickGetSizeOffset(Wand, out size));

                return (int)size;
            }
        }


        public ImageType Type
        {
            get
            {
                return MagickWandApi.MagickGetType(Wand);
            }
            set
            {
                Check(MagickWandApi.MagickSetType(Wand, value));
            }
        }


        public MagickWand()
        {
            Wand = MagickWandApi.NewMagickWand();
        }


        public MagickWand(string filename)
        {
            Wand = MagickWandApi.NewMagickWand();

            this.ReadImage(filename);
        }


        internal MagickWand(IntPtr wand)
        {
            Wand = wand;
            AdjustMemoryPressure();
        }


        internal void AdjustMemoryPressure()
        {
            if(_memPressure == 0)
            {
                _memPressure = ImageLength;
                GC.AddMemoryPressure(_memPressure);
            }
        }


        public void AdaptiveBlurImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickAdaptiveBlurImage(Wand, radius, sigma));
        }


        public void AdaptiveBlurImage(ChannelType channel, double radius, double sigma)
        {
            Check(MagickWandApi.MagickAdaptiveBlurImageChannel(Wand, channel, radius, sigma));
        }


        public void AdaptiveResizeImage(uint width, uint height)
        {
            Check(MagickWandApi.MagickAdaptiveResizeImage(Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void AdaptiveSharpenImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickAdaptiveSharpenImage(Wand, radius, sigma));
        }


        public void AdaptiveSharpenImage(ChannelType channel, double radius, double sigma)
        {
            Check(MagickWandApi.MagickAdaptiveSharpenImageChannel(Wand, channel, radius, sigma));
        }


        public void AdaptiveThresholdImage(uint width, uint height, int offset)
        {
            Check(MagickWandApi.MagickAdaptiveThresholdImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)offset));
        }


        public void AddImage(MagickWand wand)
        {
            Check(MagickWandApi.MagickAddImage(Wand, wand.Wand));
        }


        public void AddNoiseImage(NoiseType noiseType)
        {
            Check(MagickWandApi.MagickAddNoiseImage(Wand, noiseType));
        }


        public void AddNoiseImage(ChannelType channelType, NoiseType noiseType)
        {
            Check(MagickWandApi.MagickAddNoiseImageChannel(Wand, channelType, noiseType));
        }


        public void AffineTransformImage(DrawingWand drawingWand)
        {
            Check(MagickWandApi.MagickAffineTransformImage(Wand, drawingWand.Wand));
        }


        public void AnnotateImage(DrawingWand drawingWand, double x, double y, double angle, string text)
        {
            Check(MagickWandApi.MagickAnnotateImage(Wand, drawingWand.Wand, x, y, angle, text));
        }


        public void AnimateImages(string xServerName)
        {
            Check(MagickWandApi.MagickAnimateImages(Wand, xServerName));
        }


        public MagickWand AppendImages(bool stackType)
        {
            var stack = stackType ? MagickBooleanType.True : MagickBooleanType.False;

            return new MagickWand(MagickWandApi.MagickAppendImages(Wand, stack));
        }


        public void AutoGammaImage()
        {
            Check(MagickWandApi.MagickAutoGammaImage(Wand));
        }


        public void AutoGammaImage(ChannelType channel)
        {
            Check(MagickWandApi.MagickAutoGammaImageChannel(Wand, channel));
        }


        public void AutoLevelImage()
        {
            Check(MagickWandApi.MagickAutoLevelImage(Wand));
        }


        public void AutoLevelImage(ChannelType channel)
        {
            Check(MagickWandApi.MagickAutoLevelImageChannel(Wand, channel));
        }


        public void AutoOrientImage()
        {
            Check(MagickWandApi.MagickAutoOrientImage(Wand));
        }


        public void BlackThresholdImage(PixelWand pixelWand)
        {
            Check(MagickWandApi.MagickBlackThresholdImage(Wand, pixelWand.Wand));
        }


        public void BlueShiftImage(double factor)
        {
            Check(MagickWandApi.MagickBlueShiftImage(Wand, factor));
        }


        public void BlurImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickBlurImage(Wand, radius, sigma));
        }


        public void BlurImage(ChannelType channel, double radius, double sigma)
        {
            Check(MagickWandApi.MagickBlurImageChannel(Wand, channel, radius, sigma));
        }


        public void BorderImage(PixelWand pixelWand, uint width, uint height)
        {
            Check(MagickWandApi.MagickBorderImage(Wand, pixelWand.Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void BrightnessContrastImage(double brightness, double contrast)
        {
            Check(MagickWandApi.MagickBrightnessContrastImage(Wand, brightness, contrast));
        }


        public void BrightnessContrastImage(ChannelType channel, double brightness, double contrast)
        {
            Check(MagickWandApi.MagickBrightnessContrastImageChannel(Wand, channel, brightness, contrast));
        }


        public void CharcoalImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickCharcoalImage(Wand, radius, sigma));
        }


        public void ChopImage(uint width, uint height, int xOffset, int yOffset)
        {
            Check(MagickWandApi.MagickChopImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)xOffset, (IntPtr)yOffset));
        }


        public void ClampImage()
        {
            Check(MagickWandApi.MagickClampImage(Wand));
        }


        public void ClampImage(ChannelType channel)
        {
            Check(MagickWandApi.MagickClampImageChannel(Wand, channel));
        }


        public void ClipImage()
        {
            Check(MagickWandApi.MagickClipImage(Wand));
        }


        public void ClipImagePath(string pathName, bool inside)
        {
            var ins = inside ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickClipImagePath(Wand, pathName, ins));
        }


        public void ClutImage(MagickWand clutWand)
        {
            Check(MagickWandApi.MagickClutImage(Wand, clutWand.Wand));
        }


        public void ClutImage(ChannelType channel, MagickWand clutWand)
        {
            Check(MagickWandApi.MagickClutImageChannel(Wand, channel, clutWand.Wand));
        }


        public MagickWand CoalesceImages()
        {
            return new MagickWand(MagickWandApi.MagickCoalesceImages(Wand));
        }


        public void ColorDecisionListImage(string colorCorrectionCollection)
        {
            Check(MagickWandApi.MagickColorDecisionListImage(Wand, colorCorrectionCollection));
        }


        public void ColorizeImage(PixelWand colorizePixelWand, PixelWand opacity)
        {
            Check(MagickWandApi.MagickColorizeImage(Wand, colorizePixelWand.Wand, opacity.Wand));
        }


        public void ColorMatrixImage(KernelInfo kernelInfo)
        {
            Check(MagickWandApi.MagickColorMatrixImage(Wand, ref kernelInfo));
        }


        public MagickWand CombineImages(ChannelType channelType)
        {
            return new MagickWand(MagickWandApi.MagickCombineImages(Wand, channelType));
        }


        public void CommentImage(string comment)
        {
            Check(MagickWandApi.MagickCommentImage(Wand, comment));
        }


        public MagickWand CompareImageChannels(MagickWand reference, ChannelType channel, MetricType metric, out double distortion)
        {
            return new MagickWand(MagickWandApi.MagickCompareImageChannels(Wand, reference.Wand, channel, metric, out distortion));
        }


        public MagickWand CompareImages(MagickWand reference, MetricType metric, out double distortion)
        {
            return new MagickWand(MagickWandApi.MagickCompareImages(Wand, reference.Wand, metric, out distortion));
        }


        public void CompositeImage(MagickWand sourceWand, CompositeOperator compose, int x, int y)
        {
            Check(MagickWandApi.MagickCompositeImage(Wand, sourceWand.Wand, compose, (IntPtr)x, (IntPtr)y));
        }


        public void CompositeImage(ChannelType channel, MagickWand compositeWand, CompositeOperator compose, int x, int y)
        {
            Check(MagickWandApi.MagickCompositeImageChannel(Wand, channel, compositeWand.Wand, compose, (IntPtr)x, (IntPtr)y));
        }


        public void CompositeImageGravity(MagickWand sourceWand, CompositeOperator compose, GravityType gravity)
        {
            Check(MagickWandApi.MagickCompositeImageGravity(Wand, sourceWand.Wand, compose, gravity));
        }


        public void CompositeLayers(MagickWand sourceWand, CompositeOperator compose, int x, int y)
        {
            Check(MagickWandApi.MagickCompositeLayers(Wand, sourceWand.Wand, compose, (IntPtr)x, (IntPtr)y));
        }


        public void ContrastImage(bool sharpen)
        {
            var s = sharpen ? MagickBooleanType.True : MagickBooleanType.False;
            Check(MagickWandApi.MagickContrastImage(Wand, s));
        }


        public void ContrastStretchImage(double blackPoint, double whitePoint)
        {
            Check(MagickWandApi.MagickContrastStretchImage(Wand, blackPoint, whitePoint));
        }


        public void ContrastStretchImage(ChannelType channel, double blackPoint, double whitePoint)
        {
            Check(MagickWandApi.MagickContrastStretchImageChannel(Wand, channel, blackPoint, whitePoint));
        }


        public void ConvolveImage(uint order, double[] kernel)
        {
            Check(MagickWandApi.MagickConvolveImage(Wand, (UIntPtr)order, kernel));
        }


        public void ConvolveImage(ChannelType channel, uint order, double[] kernel)
        {
            Check(MagickWandApi.MagickConvolveImageChannel(Wand, channel, (UIntPtr)order, kernel));
        }


        public void CropImage(uint width, uint height, int xOffset, int yOffset)
        {
            Check(MagickWandApi.MagickCropImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)xOffset, (IntPtr)yOffset));
        }


        public void CycleColormapImage(int displace)
        {
            Check(MagickWandApi.MagickCycleColormapImage(Wand, (IntPtr)displace));
        }


        public void ConstituteImage<T>(uint width, uint height, string map, StorageType storage, T[] pixels)
        {
            throw new NotImplementedException();
            //Check(MagickWandApi.MagickConstituteImage(Wand, (UIntPtr)width, (UIntPtr)height, map, storage, pixels));
        }


        public void Clear()
        {
            MagickWandApi.ClearMagickWand(Wand);
        }


        public MagickWand Clone()
        {
            return new MagickWand(MagickWandApi.CloneMagickWand(Wand));
        }


        public void DecipherImage(string passphrase)
        {
            Check(MagickWandApi.MagickDecipherImage(Wand, passphrase));
        }


        public MagickWand DeconstructImages()
        {
            return new MagickWand(MagickWandApi.MagickDeconstructImages(Wand));
        }


        public void DeleteImageArtifact(string artifact)
        {
            Check(MagickWandApi.MagickDeleteImageArtifact(Wand, artifact));
        }


        public void DeleteImageProperty(string property)
        {
            Check(MagickWandApi.MagickDeleteImageProperty(Wand, property));
        }


        public void DeleteOption(string option)
        {
            Check(MagickWandApi.MagickDeleteOption(Wand, option));
        }


        public void DeskewImage(double threshold)
        {
            Check(MagickWandApi.MagickDeskewImage(Wand, threshold));
        }


        public void DespeckleImage()
        {
            Check(MagickWandApi.MagickDespeckleImage(Wand));
        }


        public void DistortImage(DistortImageMethod method, IReadOnlyList<double> arguments, bool bestfit)
        {
            var bf = bestfit ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickDistortImage(Wand, method, (UIntPtr)arguments.Count, arguments.ToArray(), bf));
        }


        public void DrawImage(DrawingWand drawingWand)
        {
            Check(MagickWandApi.MagickDrawImage(Wand, drawingWand.Wand));
        }


        public void EdgeImage(double radius)
        {
            Check(MagickWandApi.MagickEdgeImage(Wand, radius));
        }


        public void EmbossImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickEmbossImage(Wand, radius, sigma));
        }


        public void EncipherImage(string passphrase)
        {
            Check(MagickWandApi.MagickEncipherImage(Wand, passphrase));
        }


        public void EnhanceImage()
        {
            Check(MagickWandApi.MagickEnhanceImage(Wand));
        }


        public void EqualizeImage()
        {
            Check(MagickWandApi.MagickEqualizeImage(Wand));
        }


        public void EqualizeImage(ChannelType channel)
        {
            Check(MagickWandApi.MagickEqualizeImageChannel(Wand, channel));
        }


        public void EvaluateImage(MagickEvaluateOperator op, double value)
        {
            Check(MagickWandApi.MagickEvaluateImage(Wand, op, value));
        }


        public void EvaluateImage(ChannelType channel, MagickEvaluateOperator op, double value)
        {
            Check(MagickWandApi.MagickEvaluateImageChannel(Wand, channel, op, value));
        }


        public void EvaluateImages(MagickEvaluateOperator op)
        {
            throw new NotImplementedException();
            //Check(MagickWandApi.MagickEvaluateImages(Wand, op));
        }


        public void ExportImagePixes()
        {
            throw new NotImplementedException();
        }


        public void ExtentImage(uint width, uint height, int xOffset, int yOffset)
        {
            Check(MagickWandApi.MagickExtentImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)xOffset, (IntPtr)yOffset));
        }


        public void FilterImage(KernelInfo kernel)
        {
            throw new NotImplementedException();
            //Check(MagickWandApi.MagickFilterImage(Wand, kernel))
        }


        public void FilterImage(ChannelType channel, KernelInfo kernel)
        {
            throw new NotImplementedException();
        }


        public void FlipImage()
        {
            Check(MagickWandApi.MagickFlipImage(Wand));
        }


        public void FloodfillPaintImage(ChannelType channel, PixelWand pixelWand, double fuzz, PixelWand borderColor, int xOffset, int yOffset, bool invert)
        {
           var inv = invert ? MagickBooleanType.True : MagickBooleanType.False;

           Check(MagickWandApi.MagickFloodfillPaintImage(Wand, channel, pixelWand.Wand, fuzz, borderColor.Wand, (IntPtr)xOffset, (IntPtr)yOffset, inv));
        }


        public void FlopImage()
        {
            Check(MagickWandApi.MagickFlopImage(Wand));
        }


        public void ForwardFourierTransformImage(bool magnitude)
        {
            var mag = magnitude ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickForwardFourierTransformImage(Wand, mag));
        }


        public void FrameImage(PixelWand matteColor, uint width, uint height, int innerBevel, int outerBevel)
        {
            Check(MagickWandApi.MagickFrameImage(Wand, matteColor.Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)innerBevel, (IntPtr)outerBevel));
        }


        public void FunctionImage(MagickFunction func, IReadOnlyList<double> args)
        {
            Check(MagickWandApi.MagickFunctionImage(Wand, func, (UIntPtr)args.Count, args.ToArray()));
        }


        public void FunctionImage(ChannelType channel, MagickFunction func, IReadOnlyList<double> args)
        {
            Check(MagickWandApi.MagickFunctionImageChannel(Wand, channel, func, (UIntPtr)args.Count, args.ToArray()));
        }


        public MagickWand FxImage(string expression)
        {
            return new MagickWand(MagickWandApi.MagickFxImage(Wand, expression));
        }


        public MagickWand FxImage(ChannelType channel, string expression)
        {
            return new MagickWand(MagickWandApi.MagickFxImageChannel(Wand, channel, expression));
        }


        public void GammaImage(double gamma)
        {
            Check(MagickWandApi.MagickGammaImage(Wand, gamma));
        }


        public void GammaImage(ChannelType channel, double gamma)
        {
            Check(MagickWandApi.MagickGammaImageChannel(Wand, channel, gamma));
        }


        public void GaussianBlurImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickGaussianBlurImage(Wand, radius, sigma));
        }


        public void GaussianBlurImage(ChannelType channel, double radius, double sigma)
        {
            Check(MagickWandApi.MagickGaussianBlurImageChannel(Wand, channel, radius, sigma));
        }


        public MagickWand GetImage()
        {
            return new MagickWand(Wand);
        }


        public string GetImageArtifact(string artifact)
        {
            return MagickHelper.GetMagickString(MagickWandApi.MagickGetImageArtifact(Wand, artifact));
        }


        public IReadOnlyList<string> GetImageArtifacts(string pattern)
        {
            return MagickHelper.ExecuteMagickWandQueryStringList(Wand, pattern, MagickWandApi.MagickGetImageArtifacts);
        }


        public void GetImageBluePrimary(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetImageBluePrimary(Wand, out x, out y));
        }


        public uint GetImageChannelDepth(ChannelType channel)
        {
            return (uint)MagickWandApi.MagickGetImageChannelDepth(Wand, channel);
        }


        public double GetImageChannelDistortion(MagickWand referenceWand, ChannelType channel, MetricType metric)
        {
            double d;

            Check(MagickWandApi.MagickGetImageChannelDistortion(Wand, referenceWand.Wand, channel, metric, out d));

            return d;
        }


        public IReadOnlyList<double> GetImageChannelDistortions(MagickWand referenceWand, MetricType metric)
        {
            throw new NotImplementedException();
        }


        public IReadOnlyList<ChannelFeatures> GetImageChannelFeatures(uint distance)
        {
            throw new NotImplementedException();
        }


        public void GetImageChannelKurtosis(ChannelType channel, out double kurtosis, out double skewness)
        {
            Check(MagickWandApi.MagickGetImageChannelKurtosis(Wand, channel, out kurtosis, out skewness));
        }


        public void GetImageChannelMean(ChannelType channel, out double mean, out double standardDeviation)
        {
            Check(MagickWandApi.MagickGetImageChannelMean(Wand, channel, out mean, out standardDeviation));
        }


        public void GetImageChannelRange(ChannelType channel, out double minima, out double maxima)
        {
            Check(MagickWandApi.MagickGetImageChannelRange(Wand, channel, out minima, out maxima));
        }


        public ChannelStatistics GetImageChannelStatistics()
        {
            throw new NotImplementedException();
        }


        public MagickWand GetImageClipMask()
        {
            return new MagickWand(MagickWandApi.MagickGetImageClipMask(Wand));
        }


        public PixelWand GetImageColormapColor(uint index)
        {
            var pw = new PixelWand();

            Check(MagickWandApi.MagickGetImageColormapColor(Wand, (UIntPtr)index, pw.Wand));

            return pw;
        }


        public double GetImageDistortion(MagickWand referenceWand, MetricType metric)
        {
            double d;

            Check(MagickWandApi.MagickGetImageDistortion(Wand, referenceWand.Wand, metric, out d));

            return d;
        }


        public void GetImageGreenPrimary(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetImageGreenPrimary(Wand, out x, out y));
        }


        public IReadOnlyList<PixelWand> GetImageHistogram()
        {
            return MagickHelper.ExecuteMagickWandPixelWandList(Wand, MagickWandApi.MagickGetImageHistogram);
        }


        public void GetImagePage(out uint width, out uint height, out int xOffset, out int yOffset)
        {
            UIntPtr w,h;
            IntPtr x,y;

            Check(MagickWandApi.MagickGetImagePage(Wand, out w, out h, out x, out y));

            width = (uint)w;
            height = (uint)h;
            xOffset = (int)x;
            yOffset = (int)y;
        }


        public PixelWand GetImagePixelColor(int x, int y)
        {
            var pw = new PixelWand();

            Check(MagickWandApi.MagickGetImagePixelColor(Wand, (IntPtr)x, (IntPtr)y, pw.Wand));

            return pw;
        }


        public void GetImageRedPrimary(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetImageRedPrimary(Wand, out x, out y));
        }


        public MagickWand GetImageRegion(uint width, uint height, int xOffset, int yOffset)
        {
            return new MagickWand(MagickWandApi.MagickGetImageRegion(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)xOffset, (IntPtr)yOffset));
        }


        public void GetImageResolution(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetImageResolution(Wand, out x, out y));
        }


        public string GetImageProfile(string profileName)
        {
            UIntPtr length = UIntPtr.Zero;
            var ptr = MagickWandApi.MagickGetImageProfile(Wand, profileName, out length);

            return MagickHelper.GetMagickString(ptr, length);
        }


        public IReadOnlyList<string> GetImageProfiles(string pattern)
        {
            return MagickHelper.ExecuteMagickWandQueryStringList(Wand, pattern, MagickWandApi.MagickGetImageProfiles);
        }


        public string GetImageProperty(string property)
        {
            return MagickHelper.GetMagickString(MagickWandApi.MagickGetImageProperty(Wand, property));
        }


        public IReadOnlyList<string> GetImageProperties(string pattern)
        {
            return MagickHelper.ExecuteMagickWandQueryStringList(Wand, pattern, MagickWandApi.MagickGetImageProperties);
        }


        public void GetImageWhitePoint(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetImageWhitePoint(Wand, out x, out y));
        }


        public string GetOption(string property)
        {
            return MagickHelper.GetMagickString(MagickWandApi.MagickGetOption(Wand, property));
        }


        public IReadOnlyList<string> GetOptions(string pattern)
        {
            return MagickHelper.ExecuteMagickWandQueryStringList(Wand, pattern, MagickWandApi.MagickGetOptions);
        }


        public void GetPage(out uint width, out uint height, out int xOffset, out int yOffset)
        {
            UIntPtr w,h;
            IntPtr x,y;

            Check(MagickWandApi.MagickGetPage(Wand, out w, out h, out x, out y));

            width = (uint)w;
            height = (uint)h;
            xOffset = (int)x;
            yOffset = (int)y;
        }


        public void GetResolution(out double x, out double y)
        {
            Check(MagickWandApi.MagickGetResolution(Wand, out x, out y));
        }


        public void GetSize(out uint width, out uint height)
        {
            UIntPtr w,h;

            Check(MagickWandApi.MagickGetSize(Wand, out w, out h));

            width = (uint)w;
            height = (uint)h;
        }


        public void HaldClutImage(MagickWand haldWand)
        {
            Check(MagickWandApi.MagickHaldClutImage(Wand, haldWand.Wand));
        }


        public void HaldClutImage(ChannelType channel, MagickWand haldWand)
        {
            Check(MagickWandApi.MagickHaldClutImageChannel(Wand, channel, haldWand.Wand));
        }


        public void ImplodeImage(double radius)
        {
            Check(MagickWandApi.MagickImplodeImage(Wand, radius));
        }


        public void ImportImagePixes()
        {
            throw new NotImplementedException();
        }


        public void InverseFourierTransformImage()
        {
            throw new NotImplementedException();
        }


        public void LabelImage(string label)
        {
            Check(MagickWandApi.MagickLabelImage(Wand, label));
        }


        public void LevelImage(double blackPoint, double gamma, double whitePoint)
        {
            Check(MagickWandApi.MagickLevelImage(Wand, blackPoint, gamma, whitePoint));
        }


        public void LevelImage(ChannelType channel, double blackPoint, double gamma, double whitePoint)
        {
            Check(MagickWandApi.MagickLevelImageChannel(Wand, channel, blackPoint, gamma, whitePoint));
        }


        public void LinearStretchImage(double blackPoint, double whitePoint)
        {
            Check(MagickWandApi.MagickLinearStretchImage(Wand, blackPoint, whitePoint));
        }


        public void LiquidRescaleImage(uint width, uint height, double deltaX, double rigidity)
        {
            Check(MagickWandApi.MagickLiquidRescaleImage(Wand, (UIntPtr)width, (UIntPtr)height, deltaX, rigidity));
        }


        public void LocalContrastImage(double radius, double strength)
        {
            Check(MagickWandApi.MagickLocalContrastImage(Wand, radius, strength));
        }


        public void MagnifyImage()
        {
            Check(MagickWandApi.MagickMagnifyImage(Wand));
        }


        public MagickWand MergeImageLayers(ImageLayerMethod method)
        {
            return new MagickWand(MagickWandApi.MagickMergeImageLayers(Wand, method));
        }


        public void MinifyImage()
        {
            Check(MagickWandApi.MagickMinifyImage(Wand));
        }


        public void ModulateImage(double brightness, double saturation, double hue)
        {
            Check(MagickWandApi.MagickModulateImage(Wand, brightness, saturation, hue));
        }


        public MagickWand MontageImage(DrawingWand drawingWand, string tileGeometry, string thumbnailGeometry, MontageMode mode, string frame)
        {
            return new MagickWand(MagickWandApi.MagickMontageImage(Wand, drawingWand.Wand, tileGeometry, thumbnailGeometry, mode, frame));
        }


        public MagickWand MorphImages(uint numberFrames)
        {
            return new MagickWand(MagickWandApi.MagickMorphImages(Wand, (UIntPtr)numberFrames));
        }


        public void MorphologyImage(MorphologyMethod method, int iterations, KernelInfo kernel)
        {
            throw new NotImplementedException();
            //Check(MagickWandApi.MagickMorphologyImage(Wand, method, (IntPtr)iterations, kernel));
        }


        public void MorphologyImage(ChannelType channel, MorphologyMethod method, int iterations, KernelInfo kernel)
        {
            throw new NotImplementedException();
        }


        public void MotionBlurImage(double radius, double sigma, double angle)
        {
            Check(MagickWandApi.MagickMotionBlurImage(Wand, radius, sigma, angle));
        }


        public void MotionBlurImage(ChannelType channel, double radius, double sigma, double angle)
        {
            Check(MagickWandApi.MagickMotionBlurImageChannel(Wand, channel, radius, sigma, angle));
        }


        public void NegateImage(bool gray)
        {
            var g = gray ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickNegateImage(Wand, g));
        }


        public void NegateImage(ChannelType channel, bool gray)
        {
            var g = gray ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickNegateImageChannel(Wand, channel, g));
        }


        public void NewImage(uint width, uint height, PixelWand background)
        {
            Check(MagickWandApi.MagickNewImage(Wand, (UIntPtr)width, (UIntPtr)height, background.Wand));
        }


        public void NextImage()
        {
            Check(MagickWandApi.MagickNextImage(Wand));
        }


        public void NormalizeImage()
        {
            Check(MagickWandApi.MagickNormalizeImage(Wand));
        }


        public void NormalizeImage(ChannelType channel)
        {
            Check(MagickWandApi.MagickNormalizeImageChannel(Wand, channel));
        }


        public void OilPaintImage(double radius)
        {
            Check(MagickWandApi.MagickOilPaintImage(Wand, radius));
        }


        public void OpaquePaintImage(PixelWand target, PixelWand fill, double fuzz, bool invert)
        {
            var inv = invert ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickOpaquePaintImage(Wand, target.Wand, fill.Wand, fuzz, inv));
        }


        public void OpaquePaintImage(ChannelType channel, PixelWand target, PixelWand fill, double fuzz, bool invert)
        {
            var inv = invert ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickOpaquePaintImageChannel(Wand, channel, target.Wand, fill.Wand, fuzz, inv));
        }


        public MagickWand OptimizeImageLayers()
        {
            return new MagickWand(MagickWandApi.MagickOptimizeImageLayers(Wand));
        }


        public void OptimizeImageTransparency()
        {
            Check(MagickWandApi.MagickOptimizeImageTransparency(Wand));
        }


        public void OrderedPosterizeImage(string thresholdMap)
        {
            Check(MagickWandApi.MagickOrderedPosterizeImage(Wand, thresholdMap));
        }


        public void OrderedPosterizeImage(ChannelType channel, string thresholdMap)
        {
            Check(MagickWandApi.MagickOrderedPosterizeImageChannel(Wand, channel, thresholdMap));
        }


        public void PingImage(string filename)
        {
            Check(MagickWandApi.MagickPingImage(Wand, filename));
        }


        public void PingImageBlob()
        {
            throw new NotImplementedException();
        }


        public void PolaroidImage(DrawingWand drawingWand, double angle)
        {
            Check(MagickWandApi.MagickPolaroidImage(Wand, drawingWand.Wand, angle));
        }


        public void PosterizeImage(uint levels, bool dither)
        {
            var d = dither ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickPosterizeImage(Wand, (UIntPtr)levels, d));
        }


        public MagickWand PreviewImages(PreviewType previewType)
        {
            return new MagickWand(MagickWandApi.MagickPreviewImages(Wand, previewType));
        }


        public void PreviousImage()
        {
            Check(MagickWandApi.MagickPreviousImage(Wand));
        }


        public void ProfileImage()
        {
            throw new NotImplementedException();
        }


        public void QuantizeImage(uint numberColors, ColorspaceType colorspace, uint treeDepth, bool dither, bool measureError)
        {
            var d = dither ? MagickBooleanType.True : MagickBooleanType.False;
            var m = measureError ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickQuantizeImage(Wand, (UIntPtr)numberColors, colorspace, (UIntPtr)treeDepth, d, m));
        }


        public void QuantizeImages(uint numberColors, ColorspaceType colorspace, uint treeDepth, bool dither, bool measureError)
        {
            var d = dither ? MagickBooleanType.True : MagickBooleanType.False;
            var m = measureError ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickQuantizeImages(Wand, (UIntPtr)numberColors, colorspace, (UIntPtr)treeDepth, d, m));
        }


        public void RaiseImage(uint width, uint height, int x, int y, bool raise)
        {
            var r = raise ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickRaiseImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)x, (IntPtr)y, r));
        }


        public void RandomThresholdImage(double low, double high)
        {
            Check(MagickWandApi.MagickRandomThresholdImage(Wand, low, high));
        }


        public void RandomThresholdImage(ChannelType channel, double low, double high)
        {
            Check(MagickWandApi.MagickRandomThresholdImageChannel(Wand, channel, low, high));
        }


        public string RemoveImageProfile()
        {
            throw new NotImplementedException();
        }


        public void ReadImage(string imagePath)
        {
            if(string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Please specify a valid path to an image.", nameof(imagePath));
            }

            if(!File.Exists(imagePath))
            {
                throw new FileNotFoundException("Please make sure the image you are trying to read exists.", imagePath);
            }

            Check(MagickWandApi.MagickReadImage(Wand, imagePath));

            AdjustMemoryPressure();
        }


        public void ReadImageBlob()
        {
            throw new NotImplementedException();
        }


        public void RemapImage(MagickWand remapWand, DitherMethod ditherMethod)
        {
            Check(MagickWandApi.MagickRemapImage(Wand, remapWand.Wand, ditherMethod));
        }


        public void RemoveImage()
        {
            Check(MagickWandApi.MagickRemoveImage(Wand));
        }


        public void ResampleImage(double xResolution, double yResolution, FilterTypes filter, double blur)
        {
            Check(MagickWandApi.MagickResampleImage(Wand, xResolution, yResolution, filter, blur));
        }


        public void ResetImagePage(string page)
        {
            Check(MagickWandApi.MagickResetImagePage(Wand, page));
        }


        public void ResetIterator()
        {
            MagickWandApi.MagickResetIterator(Wand);
            CheckAndRaiseException();
        }


        public void ResizeImage(uint width, uint height, FilterTypes filter, double blur)
        {
            Check(MagickWandApi.MagickResizeImage(Wand, (UIntPtr)width, (UIntPtr)height, filter, blur));
        }


        public void RollImage(int x, int y)
        {
            Check(MagickWandApi.MagickRollImage(Wand, (IntPtr)x, (IntPtr)y));
        }


        public void RotateImage(PixelWand background, double degrees)
        {
            Check(MagickWandApi.MagickRotateImage(Wand, background.Wand, degrees));
        }


        public void RotationalBlurImage(double angle)
        {
            Check(MagickWandApi.MagickRotationalBlurImage(Wand, angle));
        }


        public void RotationalBlurImage(ChannelType channel, double angle)
        {
            Check(MagickWandApi.MagickRotationalBlurImageChannel(Wand, channel, angle));
        }


        public void SampleImage(uint width, uint height)
        {
            Check(MagickWandApi.MagickSampleImage(Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void ScaleImage(uint newWidth, uint newHeight)
        {
            Check(MagickWandApi.MagickScaleImage(Wand, (UIntPtr)newWidth, (UIntPtr)newHeight));
        }


        public void SegmentImage(ColorspaceType colorspace, bool verbose, double clusterThreshold, double smoothThreshold)
        {
            var v = verbose ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickSegmentImage(Wand, colorspace, v, clusterThreshold, smoothThreshold));
        }


        public void SelectiveBlurImage(double radius, double sigma, double threshold)
        {
            Check(MagickWandApi.MagickSelectiveBlurImage(Wand, radius, sigma, threshold));
        }


        public void SelectiveBlurImage(ChannelType channel, double radius, double sigma, double threshold)
        {
            Check(MagickWandApi.MagickSelectiveBlurImageChannel(Wand, channel, radius, sigma, threshold));
        }


        public void SeparateImageChannel(ChannelType channel)
        {
            Check(MagickWandApi.MagickSeparateImageChannel(Wand, channel));
        }


        public void SepiaToneImage(double threshold)
        {
            Check(MagickWandApi.MagickSepiaToneImage(Wand, threshold));
        }


        public void SetFirstIterator()
        {
            MagickWandApi.MagickSetFirstIterator(Wand);
            CheckAndRaiseException();
        }


        public void SetImage(MagickWand setWand)
        {
            Check(MagickWandApi.MagickSetImage(Wand, setWand.Wand));
        }


        public void SetImageAlphaChannel(AlphaChannelType alphaChannelType)
        {
            Check(MagickWandApi.MagickSetImageAlphaChannel(Wand, alphaChannelType));
        }


        public void SetImageArtifact(string artifact, string value)
        {
            Check(MagickWandApi.MagickSetImageArtifact(Wand, artifact, value));
        }


        public void SetImageBias(double bias)
        {
            Check(MagickWandApi.MagickSetImageBias(Wand, bias));
        }


        public void SetImageBluePrimary(double x, double y)
        {
            Check(MagickWandApi.MagickSetImageBluePrimary(Wand, x, y));
        }


        public void SetImageChannelDepth(ChannelType channel, uint depth)
        {
            Check(MagickWandApi.MagickSetImageChannelDepth(Wand, channel, (UIntPtr)depth));
        }


        public void SetImageClipMask(MagickWand clipMask)
        {
            Check(MagickWandApi.MagickSetImageClipMask(Wand, clipMask.Wand));
        }


        public void SetImageColor(PixelWand color)
        {
            Check(MagickWandApi.MagickSetImageColor(Wand, color.Wand));
        }


        public void SetImageColormapColor(uint index, PixelWand color)
        {
            Check(MagickWandApi.MagickSetImageColormapColor(Wand, (UIntPtr)index, color.Wand));
        }


        public void SetImageExtent(uint width, uint height)
        {
            Check(MagickWandApi.MagickSetImageExtent(Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void SetImageGreenPrimary(double x, double y)
        {
            Check(MagickWandApi.MagickSetImageGreenPrimary(Wand, x, y));
        }


        public void SetImageMatte(bool enableMatte)
        {
            var e = enableMatte ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickSetImageMatte(Wand, e));
        }


        public void SetImageOpacity(double alpha)
        {
            Check(MagickWandApi.MagickSetImageOpacity(Wand, alpha));
        }


        public void SetImagePage(uint width, uint height, int x, int y)
        {
            Check(MagickWandApi.MagickSetImagePage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)x, (IntPtr)y));
        }


        public void SetImageProfile()
        {
            throw new NotImplementedException();
        }


        public void SetImageProperty(string property, string value)
        {
            Check(MagickWandApi.MagickSetImageProperty(Wand, property, value));
        }


        public void SetImageRedPrimary(double x, double y)
        {
            Check(MagickWandApi.MagickSetImageRedPrimary(Wand, x, y));
        }


        public void SetImageResolution(double xResolution, double yResolution)
        {
            Check(MagickWandApi.MagickSetImageResolution(Wand, xResolution, yResolution));
        }


        public void SetImageWhitePoint(double x, double y)
        {
            Check(MagickWandApi.MagickSetImageWhitePoint(Wand, x, y));
        }


        public void SetLastIterator()
        {
            MagickWandApi.MagickSetLastIterator(Wand);
            CheckAndRaiseException();
        }


        public void SetOption(string key, string value)
        {
            Check(MagickWandApi.MagickSetOption(Wand, key, value));
        }


        public void SetPage(uint width, uint height, int xOffset, int yOffset)
        {
            Check(MagickWandApi.MagickSetPage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)xOffset, (IntPtr)yOffset));
        }


        public void SetPassphrase(string passphrase)
        {
            Check(MagickWandApi.MagickSetPassphrase(Wand, passphrase));
        }


        public void SetResourceLimit(ResourceType type, uint limit)
        {
            Check(MagickWandApi.MagickSetResourceLimit(type, (UIntPtr)limit));
        }


        public void SetResolution(double x, double y)
        {
            Check(MagickWandApi.MagickSetResolution(Wand, x, y));
        }


        public void SetSamplingFactors()
        {
            throw new NotImplementedException();
        }


        public void SetSize(uint widthPixels, uint heightPixels)
        {
            Check(MagickWandApi.MagickSetSize(Wand, (UIntPtr)widthPixels, (UIntPtr)heightPixels));
        }


        public void SetSizeOffset(uint width, uint height, int offset)
        {
            Check(MagickWandApi.MagickSetSizeOffset(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)offset));
        }


        public void ShadeImage(bool gray, double azimuth, double elevation)
        {
            var g = gray ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickShadeImage(Wand, g, azimuth, elevation));
        }


        public void ShadowImage(double opacity, double sigma, int x, int y)
        {
            Check(MagickWandApi.MagickShadowImage(Wand, opacity, sigma, (IntPtr)x, (IntPtr)y));
        }


        public void SharpenImage(double radius, double sigma)
        {
            Check(MagickWandApi.MagickSharpenImage(Wand, radius, sigma));
        }


        public void SharpenImage(ChannelType channel, double radius, double sigma)
        {
            Check(MagickWandApi.MagickSharpenImageChannel(Wand, channel, radius, sigma));
        }


        public void ShaveImage(uint width, uint height)
        {
            Check(MagickWandApi.MagickShaveImage(Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void ShearImage(PixelWand background, double xShear, double yShear)
        {
            Check(MagickWandApi.MagickShearImage(Wand, background.Wand, xShear, yShear));
        }


        public void SigmoidalContrastImage(bool sharpen, double alpha, double beta)
        {
            var s = sharpen ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickSigmoidalContrastImage(Wand, s, alpha, beta));
        }


        public void SigmoidalContrastImage(ChannelType channel, bool sharpen, double alpha, double beta)
        {
            var s = sharpen ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickSigmoidalContrastImageChannel(Wand, channel, s, alpha, beta));
        }


        public MagickWand SimilarityImage(MagickWand referenceWand, out RectangleInfo offset, out double similarity)
        {
            offset = new RectangleInfo();

            return new MagickWand(MagickWandApi.MagickSimilarityImage(Wand, referenceWand.Wand, ref offset, out similarity));
        }


        public void SketchImage(double radius, double sigma, double angle)
        {
            Check(MagickWandApi.MagickSketchImage(Wand, radius, sigma, angle));
        }


        public MagickWand SmushImages(bool stack, int offset)
        {
            var s = stack ? MagickBooleanType.True : MagickBooleanType.False;

            return new MagickWand(MagickWandApi.MagickSmushImages(Wand, s, (IntPtr)offset));
        }


        public void SolarizeImage(double threshold)
        {
            Check(MagickWandApi.MagickSolarizeImage(Wand, threshold));
        }


        public void SolarizeImage(ChannelType channel, double threshold)
        {
            Check(MagickWandApi.MagickSolarizeImageChannel(Wand, channel, threshold));
        }


        public void SparseColorImage(ChannelType channel, SparseColorMethod method, IReadOnlyList<double> args)
        {
            throw new NotImplementedException();
        }


        public void SpliceImage(uint width, uint height, int x, int y)
        {
            Check(MagickWandApi.MagickSpliceImage(Wand, (UIntPtr)width, (UIntPtr)height, (IntPtr)x, (IntPtr)y));
        }


        public void SpreadImage(double radius)
        {
            Check(MagickWandApi.MagickSpreadImage(Wand, radius));
        }


        public void StatisticImage(StatisticType statType, uint width, uint height)
        {
            Check(MagickWandApi.MagickStatisticImage(Wand, statType, (UIntPtr)width, (UIntPtr)height));
        }


        public MagickWand SteganoImage(MagickWand watermark, int offset)
        {
            return new MagickWand(MagickWandApi.MagickSteganoImage(Wand, watermark.Wand, (IntPtr)offset));
        }


        public MagickWand StereoImage(MagickWand offsetWand)
        {
            return new MagickWand(MagickWandApi.MagickStereoImage(Wand, offsetWand.Wand));
        }


        public void StripImage()
        {
            Check(MagickWandApi.MagickStripImage(Wand));
        }


        public void SwirlImage(double degrees)
        {
            Check(MagickWandApi.MagickSwirlImage(Wand, degrees));
        }


        public MagickWand TextureImage(MagickWand textureWand)
        {
            return new MagickWand(MagickWandApi.MagickTextureImage(Wand, textureWand.Wand));
        }


        public void ThresholdImage(double threshold)
        {
            Check(MagickWandApi.MagickThresholdImage(Wand, threshold));
        }


        public void ThresholdImage(ChannelType channel, double threshold)
        {
            Check(MagickWandApi.MagickThresholdImageChannel(Wand, channel, threshold));
        }


        public void ThumbnailImage(uint width, uint height)
        {
            Check(MagickWandApi.MagickThumbnailImage(Wand, (UIntPtr)width, (UIntPtr)height));
        }


        public void TintImage(PixelWand tint, PixelWand opacity)
        {
            Check(MagickWandApi.MagickTintImage(Wand, tint.Wand, opacity.Wand));
        }


        public MagickWand TransformImage(string crop, string geometry)
        {
            return new MagickWand(MagickWandApi.MagickTransformImage(Wand, crop, geometry));
        }


        public void TransformImageColorspace(ColorspaceType colorspace)
        {
            Check(MagickWandApi.MagickTransformImageColorspace(Wand, colorspace));
        }


        public void TransparentPaintImage(PixelWand target, double alpha, double fuzz, bool invert)
        {
            var inv = invert ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickTransparentPaintImage(Wand, target.Wand, alpha, fuzz, inv));
        }


        public void TransposeImage()
        {
            Check(MagickWandApi.MagickTransposeImage(Wand));
        }


        public void TransverseImage()
        {
            Check(MagickWandApi.MagickTransverseImage(Wand));
        }


        public void TrimImage(double fuzz)
        {
            Check(MagickWandApi.MagickTrimImage(Wand, fuzz));
        }


        public void UniqueImageColors()
        {
            Check(MagickWandApi.MagickUniqueImageColors(Wand));
        }


        public void UnsharpMaskImage(double radius, double sigma, double amount, double threshold)
        {
            Check(MagickWandApi.MagickUnsharpMaskImage(Wand, radius, sigma, amount, threshold));
        }


        public void UnsharpMaskImage(ChannelType channel, double radius, double sigma, double amount, double threshold)
        {
            Check(MagickWandApi.MagickUnsharpMaskImageChannel(Wand, channel, radius, sigma, amount, threshold));
        }


        public void VignetteImage(double blackPoint, double whitePoint, int x, int y)
        {
            Check(MagickWandApi.MagickVignetteImage(Wand, blackPoint, whitePoint, (IntPtr)x, (IntPtr)y));
        }


        public void WaveImage(double amplitude, double waveLength)
        {
            Check(MagickWandApi.MagickWaveImage(Wand, amplitude, waveLength));
        }


        public void WhiteThresholdImage(PixelWand threshold)
        {
            Check(MagickWandApi.MagickWhiteThresholdImage(Wand, threshold.Wand));
        }


        public void WriteImage(string imagePath, bool overwrite)
        {
            if(string.IsNullOrEmpty(imagePath))
            {
                throw new ArgumentException("Please specify a valid path for the image to write.", nameof(imagePath));
            }

            var dir = Path.GetDirectoryName(imagePath);
            
            if(!string.IsNullOrWhiteSpace(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else if(!overwrite && File.Exists(imagePath))
            {
                throw new MagickWandException($"An image already exists at the specified path: {imagePath}.");
            }

            Check(MagickWandApi.MagickWriteImage(Wand, imagePath));
        }


        public void WriteImage(Stream stream)
        {
            UIntPtr len;
            
            var ptr = MagickWandApi.MagickGetImageBlob(Wand, out len);
            var length = (int)len;
            var buffer = new byte[length];
            
            Marshal.Copy(ptr, buffer, 0, length);
            
            stream.Write(buffer, 0, length);
            stream.Seek(0, SeekOrigin.Begin);
            
            MagickWandApi.MagickRelinquishMemory(ptr);
        }
        

        public void WriteImages(string filename, bool adjoin)
        {
            var a = adjoin ? MagickBooleanType.True : MagickBooleanType.False;

            Check(MagickWandApi.MagickWriteImages(Wand, filename, a));
        }


        public void GetLargestDimensionsKeepingAspectRatio(uint maxWidth, uint maxHeight, out uint scaledWidth, out uint scaledHeight)
        {
            double origRatio = (double) ImageHeight / (double) ImageWidth;
            double requestedRatio = (double) maxHeight / (double) maxWidth;

            if(origRatio >= requestedRatio)
            {
                // height will be the max value, reset the width
                scaledHeight = maxHeight;
                scaledWidth = Convert.ToUInt32(((double) 1 / origRatio) * maxHeight);
            }
            else
            {
                // width will be the max value, reset the height
                scaledWidth = maxWidth;
                scaledHeight = Convert.ToUInt32(origRatio * (double) maxWidth);
            }
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
            var msgPtr = MagickWandApi.MagickGetException(Wand, ref exType);

            if(exType != ExceptionType.UndefinedException)
            {
                var msg = MagickHelper.GetMagickString(msgPtr);

                MagickWandApi.MagickRelinquishMemory(msgPtr);
                MagickWandApi.MagickClearException(Wand);

                throw new MagickWandException(exType, msg);
            }
        }


        MagickBooleanType ConvertBoolean(bool value)
        {
            return value ? MagickBooleanType.True : MagickBooleanType.False;
        }


        ~MagickWand()
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
            if(Wand != IntPtr.Zero)
            {
                MagickWandApi.DestroyMagickWand(Wand);

                Wand = IntPtr.Zero;

                if(_memPressure > 0)
                {
                    GC.RemoveMemoryPressure(_memPressure);
                }
            }
        }
    }
}
