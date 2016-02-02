namespace NMagickWand
{
    public enum ColorspaceType
    {
        UndefinedColorspace,
        RGBColorspace,            /* Linear RGB colorspace */
        GRAYColorspace,           /* greyscale (linear) image (faked 1 channel) */
        TransparentColorspace,
        OHTAColorspace,
        LabColorspace,
        XYZColorspace,
        YCbCrColorspace,
        YCCColorspace,
        YIQColorspace,
        YPbPrColorspace,
        YUVColorspace,
        CMYKColorspace,           /* negated linear RGB with black separated */
        sRGBColorspace,           /* Default: non-linear sRGB colorspace */
        HSBColorspace,
        HSLColorspace,
        HWBColorspace,
        Rec601LumaColorspace,
        Rec601YCbCrColorspace,
        Rec709LumaColorspace,
        Rec709YCbCrColorspace,
        LogColorspace,
        CMYColorspace,            /* negated linear RGB colorspace */
        LuvColorspace,
        HCLColorspace,
        LCHColorspace,            /* alias for LCHuv */
        LMSColorspace,
        LCHabColorspace,          /* Cylindrical (Polar) Lab */
        LCHuvColorspace,          /* Cylindrical (Polar) Luv */
        scRGBColorspace,
        HSIColorspace,
        HSVColorspace,            /* alias for HSB */
        HCLpColorspace,
        YDbDrColorspace,
        xyYColorspace
    }
}
