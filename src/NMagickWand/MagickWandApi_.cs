// -------------------------------------------------------------------
// generated from system: Linux 4.3.3-303.fc23.x86_64 #1 SMP Tue Jan 19 18:31:55 UTC 2016 x86_64 x86_64 x86_64 GNU/Linux
// generated from library: /lib64/libMagickWand-6.Q16.so
// generated from include: /usr/include/ImageMagick-6/wand/MagickWand.h
// generated on: Wed Feb  3 18:20:23 EST 2016
// -------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;


namespace NMagickWand
{
    public static partial class MagickWandApi
    {
        const string LIB = "libMagickWand";

        // -------------------------------------------------------------------
        // MagickWand.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr MagickGetException(IntPtr magickWand1, ref ExceptionType exType2);
        

        [DllImport(LIB)]
        public static extern ExceptionType MagickGetExceptionType(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsMagickWand(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsMagickWandInstantiated();
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClearException(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetIteratorIndex(IntPtr magickWand1, IntPtr ssizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr CloneMagickWand(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyMagickWand(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr NewMagickWand();
        

        [DllImport(LIB)]
        public static extern IntPtr NewMagickWandFromImage(IntPtr image1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetIteratorIndex(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern void ClearMagickWand(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern void MagickWandGenesis();
        

        [DllImport(LIB)]
        public static extern void MagickWandTerminus();
        

        [DllImport(LIB)]
        public static extern IntPtr MagickRelinquishMemory(IntPtr ptr1);
        

        [DllImport(LIB)]
        public static extern void MagickResetIterator(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern void MagickSetFirstIterator(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern void MagickSetLastIterator(IntPtr magickWand1);
        


        // -------------------------------------------------------------------
        // animate.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType AnimateImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // compare.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType CompareImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // composite.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType CompositeImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // conjure.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType ConjureImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // convert.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType ConvertImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // display.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType DisplayImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // drawing-wand.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern AlignType DrawGetTextAlignment(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetClipPath(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetDensity(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetException(IntPtr drawingWand1, ref ExceptionType exType2);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetFont(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetFontFamily(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetTextEncoding(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetVectorGraphics(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern ClipPathUnits DrawGetClipUnits(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern DecorationType DrawGetTextDecoration(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern DirectionType DrawGetTextDirection(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetFillOpacity(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetFontSize(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetOpacity(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawGetStrokeDashArray(IntPtr drawingWand1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern double DrawGetStrokeDashOffset(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetStrokeOpacity(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetStrokeWidth(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetTextKerning(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetTextInterlineSpacing(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern double DrawGetTextInterwordSpacing(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr PeekDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr CloneDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DrawAllocateWand(IntPtr drawInfo1, IntPtr image2);
        

        [DllImport(LIB)]
        public static extern IntPtr NewDrawingWand();
        

        [DllImport(LIB)]
        public static extern ExceptionType DrawGetExceptionType(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern FillRule DrawGetClipRule(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern FillRule DrawGetFillRule(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern GravityType DrawGetGravity(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern LineCap DrawGetStrokeLineCap(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern LineJoin DrawGetStrokeLineJoin(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawClearException(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawComposite(IntPtr drawingWand1, CompositeOperator op2, [In] double val3, [In] double val4, [In] double val5, [In] double val6, IntPtr magickWand7);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawGetFontResolution(IntPtr drawingWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawGetStrokeAntialias(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawGetTextAntialias(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawPopPattern(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawPushPattern(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, [In] double val3, [In] double val4, [In] double val5, [In] double val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawRender(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetClipPath(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetDensity(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetFillPatternURL(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetFont(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetFontFamily(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetFontResolution(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetStrokeDashArray(IntPtr drawingWand1, UIntPtr sizetVal2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetStrokePatternURL(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DrawSetVectorGraphics(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PopDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PushDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern StretchType DrawGetFontStretch(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern StyleType DrawGetFontStyle(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr DrawGetFontWeight(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr DrawGetStrokeMiterLimit(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void ClearDrawingWand(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawAffine(IntPtr drawingWand1, ref AffineMatrix affineMatrix2);
        

        [DllImport(LIB)]
        public static extern void DrawAnnotation(IntPtr drawingWand1, [In] double val2, [In] double val3, [MarshalAs(UnmanagedType.LPStr)]string str4);
        

        [DllImport(LIB)]
        public static extern void DrawArc(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5, [In] double val6, [In] double val7);
        

        [DllImport(LIB)]
        public static extern void DrawBezier(IntPtr drawingWand1, UIntPtr sizetVal2, ref PointInfo pointInfo3);
        

        [DllImport(LIB)]
        public static extern void DrawGetBorderColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawCircle(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawColor(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] PaintMethod paintMethod4);
        

        [DllImport(LIB)]
        public static extern void DrawComment(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern void DrawEllipse(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5, [In] double val6, [In] double val7);
        

        [DllImport(LIB)]
        public static extern void DrawGetFillColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawGetStrokeColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextKerning(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextInterlineSpacing(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextInterwordSpacing(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawGetTextUnderColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawLine(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawMatte(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] PaintMethod paintMethod4);
        

        [DllImport(LIB)]
        public static extern void DrawPathClose(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5, [In] double val6, [In] double val7);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToRelative(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5, [In] double val6, [In] double val7);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToQuadraticBezierAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToQuadraticBezierRelative(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToQuadraticBezierSmoothAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToQuadraticBezierSmoothRelative(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToSmoothAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawPathCurveToSmoothRelative(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawPathEllipticArcAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, MagickBooleanType val5, MagickBooleanType val6, [In] double val7, [In] double val8);
        

        [DllImport(LIB)]
        public static extern void DrawPathEllipticArcRelative(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, MagickBooleanType val5, MagickBooleanType val6, [In] double val7, [In] double val8);
        

        [DllImport(LIB)]
        public static extern void DrawPathFinish(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToRelative(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToHorizontalAbsolute(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToHorizontalRelative(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToVerticalAbsolute(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawPathLineToVerticalRelative(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawPathMoveToAbsolute(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathMoveToRelative(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPathStart(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawPoint(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawPolygon(IntPtr drawingWand1, UIntPtr sizetVal2, ref PointInfo pointInfo3);
        

        [DllImport(LIB)]
        public static extern void DrawPolyline(IntPtr drawingWand1, UIntPtr sizetVal2, ref PointInfo pointInfo3);
        

        [DllImport(LIB)]
        public static extern void DrawPopClipPath(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawPopDefs(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawPushClipPath(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern void DrawPushDefs(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawRectangle(IntPtr drawingWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern void DrawResetVectorGraphics(IntPtr drawingWand1);
        

        [DllImport(LIB)]
        public static extern void DrawRotate(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawRoundRectangle(IntPtr drawingWand1, double val2, double val3, double val4, double val5, double val6, double val7);
        

        [DllImport(LIB)]
        public static extern void DrawScale(IntPtr drawingWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern void DrawSetBorderColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawSetClipRule(IntPtr drawingWand1, [In] FillRule fillRule2);
        

        [DllImport(LIB)]
        public static extern void DrawSetClipUnits(IntPtr drawingWand1, [In] ClipPathUnits clipPathUnits2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFillColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFillOpacity(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFillRule(IntPtr drawingWand1, [In] FillRule fillRule2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFontSize(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFontStretch(IntPtr drawingWand1, [In] StretchType stretchType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFontStyle(IntPtr drawingWand1, [In] StyleType styleType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetFontWeight(IntPtr drawingWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern void DrawSetGravity(IntPtr drawingWand1, [In] GravityType gravityType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetOpacity(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeAntialias(IntPtr drawingWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeDashOffset(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeLineCap(IntPtr drawingWand1, [In] LineCap lineCap2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeLineJoin(IntPtr drawingWand1, [In] LineJoin lineJoin2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeMiterLimit(IntPtr drawingWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeOpacity(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetStrokeWidth(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextAlignment(IntPtr drawingWand1, [In] AlignType alignType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextAntialias(IntPtr drawingWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextDecoration(IntPtr drawingWand1, [In] DecorationType decorationType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextDirection(IntPtr drawingWand1, [In] DirectionType directionType2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextEncoding(IntPtr drawingWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern void DrawSetTextUnderColor(IntPtr drawingWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void DrawSetViewbox(IntPtr drawingWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern void DrawSkewX(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawSkewY(IntPtr drawingWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void DrawTranslate(IntPtr drawingWand1, [In] double val2, [In] double val3);
        


        // -------------------------------------------------------------------
        // identify.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType IdentifyImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // import.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType ImportImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // magick-image.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageChannelFeatures(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageChannelStatistics(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageFilename(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageFormat(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageSignature(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickIdentifyImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern ColorspaceType MagickGetImageColorspace(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern CompositeOperator MagickGetImageCompose(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern CompressionType MagickGetImageCompression(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern DisposeType MagickGetImageDispose(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageChannelDistortions(IntPtr magickWand1, IntPtr magickWand2, [In] MetricType metricType3);
        

        [DllImport(LIB)]
        public static extern double MagickGetImageFuzz(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern double MagickGetImageGamma(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern double MagickGetImageTotalInkDensity(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern EndianType MagickGetImageEndian(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern GravityType MagickGetImageGravity(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickDestroyImage(IntPtr image1);
        

        [DllImport(LIB)]
        public static extern IntPtr GetImageFromMagickWand(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern ImageType MagickGetImageType(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern InterlaceType MagickGetImageInterlaceScheme(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern InterpolatePixelMethod MagickGetImageInterpolateMethod(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveBlurImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveResizeImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveSharpenImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveSharpenImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAdaptiveThresholdImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAddImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAddNoiseImage(IntPtr magickWand1, [In] NoiseType noiseType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAddNoiseImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] NoiseType noiseType3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAffineTransformImage(IntPtr magickWand1, IntPtr drawingWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAnnotateImage(IntPtr magickWand1, IntPtr drawingWand2, [In] double val3, [In] double val4, [In] double val5, [MarshalAs(UnmanagedType.LPStr)]string str6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAnimateImages(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAutoGammaImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAutoGammaImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAutoLevelImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAutoLevelImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickAutoOrientImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBlackThresholdImage(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBlueShiftImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBlurImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBorderImage(IntPtr magickWand1, IntPtr pixelWand2, UIntPtr sizetVal3, UIntPtr sizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBrightnessContrastImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickBrightnessContrastImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCharcoalImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickChopImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClampImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClampImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClipImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClipImagePath(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, MagickBooleanType val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClutImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickClutImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, IntPtr magickWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickColorDecisionListImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickColorizeImage(IntPtr magickWand1, IntPtr pixelWand2, IntPtr pixelWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickColorMatrixImage(IntPtr magickWand1, ref KernelInfo kernelInfo2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCommentImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCompositeImage(IntPtr magickWand1, IntPtr magickWand2, CompositeOperator op3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCompositeImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, IntPtr magickWand3, CompositeOperator op4, IntPtr ssizetVal5, IntPtr ssizetVal6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCompositeImageGravity(IntPtr magickWand1, IntPtr magickWand2, CompositeOperator op3, [In] GravityType gravityType4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCompositeLayers(IntPtr magickWand1, IntPtr magickWand2, CompositeOperator op3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickConstituteImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, [MarshalAs(UnmanagedType.LPStr)]string str4, [In] StorageType storageType5, IntPtr ptr6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickContrastImage(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickContrastStretchImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickContrastStretchImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickConvolveImage(IntPtr magickWand1, UIntPtr sizetVal2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickConvolveImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, UIntPtr sizetVal3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCropImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCycleColormapImage(IntPtr magickWand1, IntPtr ssizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDecipherImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDeskewImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDespeckleImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDisplayImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDisplayImages(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDistortImage(IntPtr magickWand1, [In] DistortImageMethod distortImageMethod2, UIntPtr sizetVal3, [In] double val4, MagickBooleanType val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDrawImage(IntPtr magickWand1, IntPtr drawingWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEdgeImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEmbossImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEncipherImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEnhanceImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEqualizeImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEqualizeImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEvaluateImage(IntPtr magickWand1, [In] MagickEvaluateOperator magickEvaluateOperator2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickEvaluateImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] MagickEvaluateOperator magickEvaluateOperator3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickExportImagePixels(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, UIntPtr sizetVal4, UIntPtr sizetVal5, [MarshalAs(UnmanagedType.LPStr)]string str6, [In] StorageType storageType7, IntPtr ptr8);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickExtentImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFilterImage(IntPtr magickWand1, ref KernelInfo kernelInfo2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFilterImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, ref KernelInfo kernelInfo3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFlipImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFloodfillPaintImage(IntPtr magickWand1, [In] ChannelType channelType2, IntPtr pixelWand3, [In] double val4, IntPtr pixelWand5, IntPtr ssizetVal6, IntPtr ssizetVal7, MagickBooleanType val8);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFlopImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickForwardFourierTransformImage(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFrameImage(IntPtr magickWand1, IntPtr pixelWand2, UIntPtr sizetVal3, UIntPtr sizetVal4, IntPtr ssizetVal5, IntPtr ssizetVal6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFunctionImage(IntPtr magickWand1, [In] MagickFunction magickFunction2, UIntPtr sizetVal3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickFunctionImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] MagickFunction magickFunction3, UIntPtr sizetVal4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGammaImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGammaImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGaussianBlurImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGaussianBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageAlphaChannel(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageBackgroundColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageBluePrimary(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageBorderColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageChannelDistortion(IntPtr magickWand1, IntPtr magickWand2, [In] ChannelType channelType3, [In] MetricType metricType4, ref double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageChannelKurtosis(IntPtr magickWand1, [In] ChannelType channelType2, ref double val3, ref double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageChannelMean(IntPtr magickWand1, [In] ChannelType channelType2, ref double val3, ref double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageChannelRange(IntPtr magickWand1, [In] ChannelType channelType2, ref double val3, ref double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageColormapColor(IntPtr magickWand1, UIntPtr sizetVal2, IntPtr pixelWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageDistortion(IntPtr magickWand1, IntPtr magickWand2, [In] MetricType metricType3, ref double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageGreenPrimary(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageMatteColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageLength(IntPtr magickWand1, ref IntPtr magickSizeTypePtr2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImagePage(IntPtr magickWand1, ref UIntPtr sizetVal2, ref UIntPtr sizetVal3, ref IntPtr ssizetVal4, ref IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImagePixelColor(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, IntPtr pixelWand4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageRange(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageRedPrimary(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageResolution(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetImageWhitePoint(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickHaldClutImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickHaldClutImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, IntPtr magickWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickHasNextImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickHasPreviousImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickImplodeImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickImportImagePixels(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, UIntPtr sizetVal4, UIntPtr sizetVal5, [MarshalAs(UnmanagedType.LPStr)]string str6, [In] StorageType storageType7, IntPtr ptr8);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickInverseFourierTransformImage(IntPtr magickWand1, IntPtr magickWand2, MagickBooleanType val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLabelImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLevelImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLevelImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLinearStretchImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLiquidRescaleImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickLocalContrastImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMagnifyImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMedianFilterImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMinifyImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickModeImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickModulateImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMorphologyImage(IntPtr magickWand1, MorphologyMethod val2, IntPtr ssizetVal3, ref KernelInfo kernelInfo4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMorphologyImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, MorphologyMethod val3, IntPtr ssizetVal4, ref KernelInfo kernelInfo5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMotionBlurImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickMotionBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNegateImage(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNegateImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, MagickBooleanType val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNewImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr pixelWand4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNextImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNormalizeImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickNormalizeImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOilPaintImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOpaquePaintImage(IntPtr magickWand1, IntPtr pixelWand2, IntPtr pixelWand3, [In] double val4, MagickBooleanType val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOpaquePaintImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, IntPtr pixelWand3, IntPtr pixelWand4, [In] double val5, MagickBooleanType val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOrderedPosterizeImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOrderedPosterizeImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickOptimizeImageTransparency(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTransparentPaintImage(IntPtr magickWand1, IntPtr pixelWand2, [In] double val3, [In] double val4, MagickBooleanType val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPingImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPingImageBlob(IntPtr magickWand1, IntPtr ptr2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPingImageFile(IntPtr magickWand1, IntPtr file2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPolaroidImage(IntPtr magickWand1, IntPtr drawingWand2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPosterizeImage(IntPtr magickWand1, UIntPtr sizetVal2, MagickBooleanType val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickPreviousImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickQuantizeImage(IntPtr magickWand1, UIntPtr sizetVal2, [In] ColorspaceType colorspaceType3, UIntPtr sizetVal4, MagickBooleanType val5, MagickBooleanType val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickQuantizeImages(IntPtr magickWand1, UIntPtr sizetVal2, [In] ColorspaceType colorspaceType3, UIntPtr sizetVal4, MagickBooleanType val5, MagickBooleanType val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRaiseImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5, MagickBooleanType val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRandomThresholdImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRandomThresholdImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickReadImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickReadImageBlob(IntPtr magickWand1, IntPtr ptr2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickReadImageFile(IntPtr magickWand1, IntPtr file2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickReduceNoiseImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRemapImage(IntPtr magickWand1, IntPtr magickWand2, [In] DitherMethod ditherMethod3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRemoveImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickResampleImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] FilterTypes filterTypes4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickResetImagePage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickResizeImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, [In] FilterTypes filterTypes4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRollImage(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRotateImage(IntPtr magickWand1, IntPtr pixelWand2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRotationalBlurImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickRotationalBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSampleImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickScaleImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSegmentImage(IntPtr magickWand1, [In] ColorspaceType colorspaceType2, MagickBooleanType val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSelectiveBlurImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSelectiveBlurImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSeparateImageChannel(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSepiaToneImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageAlphaChannel(IntPtr magickWand1, [In] AlphaChannelType alphaChannelType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageBackgroundColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageBias(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageBluePrimary(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageBorderColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageChannelDepth(IntPtr magickWand1, [In] ChannelType channelType2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageClipMask(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageColormapColor(IntPtr magickWand1, UIntPtr sizetVal2, IntPtr pixelWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageColorspace(IntPtr magickWand1, [In] ColorspaceType colorspaceType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageCompose(IntPtr magickWand1, CompositeOperator op2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageCompression(IntPtr magickWand1, CompressionType compressionType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageDelay(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageDepth(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageDispose(IntPtr magickWand1, DisposeType disposeType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageCompressionQuality(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageEndian(IntPtr magickWand1, [In] EndianType endianType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageExtent(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageFilename(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageFormat(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageFuzz(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageGamma(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageGravity(IntPtr magickWand1, [In] GravityType gravityType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageGreenPrimary(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageInterlaceScheme(IntPtr magickWand1, [In] InterlaceType interlaceType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageInterpolateMethod(IntPtr magickWand1, [In] InterpolatePixelMethod interpolatePixelMethod2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageIterations(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageMatte(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageMatteColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageOpacity(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageOrientation(IntPtr magickWand1, [In] OrientationType orientationType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImagePage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageRedPrimary(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageRenderingIntent(IntPtr magickWand1, [In] RenderingIntent renderingIntent2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageResolution(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageScene(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageTicksPerSecond(IntPtr magickWand1, IntPtr ssizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageType(IntPtr magickWand1, [In] ImageType imageType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageUnits(IntPtr magickWand1, [In] ResolutionType resolutionType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageWhitePoint(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickShadeImage(IntPtr magickWand1, MagickBooleanType val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickShadowImage(IntPtr magickWand1, [In] double val2, [In] double val3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSharpenImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSharpenImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickShaveImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickShearImage(IntPtr magickWand1, IntPtr pixelWand2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSigmoidalContrastImage(IntPtr magickWand1, MagickBooleanType val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSigmoidalContrastImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, MagickBooleanType val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSketchImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSolarizeImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSolarizeImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSparseColorImage(IntPtr magickWand1, [In] ChannelType channelType2, [In] SparseColorMethod sparseColorMethod3, UIntPtr sizetVal4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSpliceImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSpreadImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickStatisticImage(IntPtr magickWand1, [In] StatisticType statisticType2, UIntPtr sizetVal3, UIntPtr sizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickStatisticImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] StatisticType statisticType3, UIntPtr sizetVal4, UIntPtr sizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickStripImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSwirlImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTintImage(IntPtr magickWand1, IntPtr pixelWand2, IntPtr pixelWand3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTransformImageColorspace(IntPtr magickWand1, [In] ColorspaceType colorspaceType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTransposeImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTransverseImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickThresholdImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickThresholdImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickThumbnailImage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickTrimImage(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickUniqueImageColors(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickUnsharpMaskImage(IntPtr magickWand1, [In] double val2, [In] double val3, [In] double val4, [In] double val5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickUnsharpMaskImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [In] double val3, [In] double val4, [In] double val5, [In] double val6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickVignetteImage(IntPtr magickWand1, [In] double val2, [In] double val3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWaveImage(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWhiteThresholdImage(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWriteImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWriteImageFile(IntPtr magickWand1, IntPtr file2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWriteImages(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, MagickBooleanType val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickWriteImagesFile(IntPtr magickWand1, IntPtr file2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickSetImageProgressMonitor(IntPtr magickWand1, IntPtr mon2, IntPtr ptr3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickAppendImages(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickCoalesceImages(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickCombineImages(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickCompareImageChannels(IntPtr magickWand1, IntPtr magickWand2, [In] ChannelType channelType3, [In] MetricType metricType4, ref double val5);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickCompareImages(IntPtr magickWand1, IntPtr magickWand2, [In] MetricType metricType3, ref double val4);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickCompareImageLayers(IntPtr magickWand1, [In] ImageLayerMethod imageLayerMethod2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickDeconstructImages(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickEvaluateImages(IntPtr magickWand1, [In] MagickEvaluateOperator magickEvaluateOperator2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickFxImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickFxImageChannel(IntPtr magickWand1, [In] ChannelType channelType2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImage(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageClipMask(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageRegion(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickMergeImageLayers(IntPtr magickWand1, [In] ImageLayerMethod imageLayerMethod2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickMorphImages(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickMontageImage(IntPtr magickWand1, IntPtr drawingWand2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, [In] MontageMode montageMode5, [MarshalAs(UnmanagedType.LPStr)]string str6);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickOptimizeImageLayers(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickPreviewImages(IntPtr magickWand1, [In] PreviewType previewType2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickSimilarityImage(IntPtr magickWand1, IntPtr magickWand2, ref RectangleInfo rectangleInfo3, ref double val4);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickSmushImages(IntPtr magickWand1, MagickBooleanType val2, IntPtr ssizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickSteganoImage(IntPtr magickWand1, IntPtr magickWand2, IntPtr ssizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickStereoImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickTextureImage(IntPtr magickWand1, IntPtr magickWand2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickTransformImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern OrientationType MagickGetImageOrientation(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageHistogram(IntPtr magickWand1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern RenderingIntent MagickGetImageRenderingIntent(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern ResolutionType MagickGetImageUnits(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageColors(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageCompressionQuality(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageDelay(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageChannelDepth(IntPtr magickWand1, [In] ChannelType channelType2);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageDepth(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageHeight(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageIterations(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageScene(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageTicksPerSecond(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetImageWidth(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetNumberImages(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageBlob(IntPtr magickWand1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImagesBlob(IntPtr magickWand1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern VirtualPixelMethod MagickGetImageVirtualPixelMethod(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern VirtualPixelMethod MagickSetImageVirtualPixelMethod(IntPtr magickWand1, [In] VirtualPixelMethod virtualPixelMethod2);
        


        // -------------------------------------------------------------------
        // magick-property.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr MagickGetFilename(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetFormat(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetFont(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetHomeURL();
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageArtifact(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageArtifacts(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, ref UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageProfiles(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, ref UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageProperty(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageProperties(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, out UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetOption(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetOptions(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, ref UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryConfigureOption([MarshalAs(UnmanagedType.LPStr)]string str1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryConfigureOptions([MarshalAs(UnmanagedType.LPStr)]string str1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryFonts([MarshalAs(UnmanagedType.LPStr)]string str1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryFormats([MarshalAs(UnmanagedType.LPStr)]string str1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern ColorspaceType MagickGetColorspace(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern CompressionType MagickGetCompression(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetCopyright();
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetPackageName();
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetQuantumDepth(ref UIntPtr sizetVal1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetQuantumRange(ref UIntPtr sizetVal1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetReleaseDate();
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetVersion(ref UIntPtr sizetVal1);
        

        [DllImport(LIB)]
        public static extern double MagickGetPointsize(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetSamplingFactors(IntPtr magickWand1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryFontMetrics(IntPtr magickWand1, IntPtr drawingWand2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickQueryMultilineFontMetrics(IntPtr magickWand1, IntPtr drawingWand2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern GravityType MagickGetGravity(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern ImageType MagickGetType(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern InterlaceType MagickGetInterlaceScheme(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern InterpolatePixelMethod MagickGetInterpolateMethod(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern OrientationType MagickGetOrientation(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDeleteImageArtifact(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDeleteImageProperty(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickDeleteOption(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetAntialias(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetPage(IntPtr magickWand1, ref UIntPtr sizetVal2, ref UIntPtr sizetVal3, ref IntPtr ssizetVal4, ref IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetResolution(IntPtr magickWand1, ref double val2, ref double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetSize(IntPtr magickWand1, ref UIntPtr sizetVal2, ref UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickGetSizeOffset(IntPtr magickWand1, ref IntPtr ssizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickProfileImage(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, IntPtr ptr3, UIntPtr sizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetAntialias(IntPtr magickWand1, MagickBooleanType val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetBackgroundColor(IntPtr magickWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetColorspace(IntPtr magickWand1, [In] ColorspaceType colorspaceType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetCompression(IntPtr magickWand1, CompressionType compressionType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetCompressionQuality(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetDepth(IntPtr magickWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetExtract(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetFilename(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetFormat(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetFont(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetGravity(IntPtr magickWand1, [In] GravityType gravityType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageArtifact(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageProfile(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, IntPtr ptr3, UIntPtr sizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetImageProperty(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetInterlaceScheme(IntPtr magickWand1, [In] InterlaceType interlaceType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetInterpolateMethod(IntPtr magickWand1, [In] InterpolatePixelMethod interpolatePixelMethod2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetOption(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, [MarshalAs(UnmanagedType.LPStr)]string str3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetOrientation(IntPtr magickWand1, [In] OrientationType orientationType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetPage(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4, IntPtr ssizetVal5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetPassphrase(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetPointsize(IntPtr magickWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetResolution(IntPtr magickWand1, [In] double val2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetResourceLimit([In] ResourceType resourceType1, IntPtr magicSizeType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetSamplingFactors(IntPtr magickWand1, UIntPtr sizetVal2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetSize(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetSizeOffset(IntPtr magickWand1, UIntPtr sizetVal2, UIntPtr sizetVal3, IntPtr ssizetVal4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MagickSetType(IntPtr magickWand1, [In] ImageType imageType2);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickSetProgressMonitor(IntPtr magickWand1, IntPtr mon2, IntPtr ptr3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetResource([In] ResourceType resourceType1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetResourceLimit([In] ResourceType resourceType1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetBackgroundColor(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern OrientationType MagickGetOrientationType(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr MagickGetCompressionQuality(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickGetImageProfile(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, ref UIntPtr sizetVal3);
        

        [DllImport(LIB)]
        public static extern IntPtr MagickRemoveImageProfile(IntPtr magickWand1, [MarshalAs(UnmanagedType.LPStr)]string str2, ref UIntPtr sizetVal3);
        


        // -------------------------------------------------------------------
        // method-attribute.h
        // -------------------------------------------------------------------

        // -------------------------------------------------------------------
        // mogrify.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType MagickCommandGenesis(IntPtr imageInfo1, IntPtr magickCommand2, int val3, [MarshalAs(UnmanagedType.LPStr)]string str4, [MarshalAs(UnmanagedType.LPStr)]string str5, IntPtr exceptionInfo6);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MogrifyImage(IntPtr imageInfo1, [In] int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, IntPtr image4, IntPtr exceptionInfo5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MogrifyImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MogrifyImageInfo(IntPtr imageInfo1, [In] int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, IntPtr exceptionInfo4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MogrifyImageList(IntPtr imageInfo1, [In] int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, IntPtr image4, IntPtr exceptionInfo5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType MogrifyImages(IntPtr imageInfo1, MagickBooleanType val2, [In] int val3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr image5, IntPtr exceptionInfo6);
        


        // -------------------------------------------------------------------
        // montage.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType MontageImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // pixel-iterator.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr PixelGetIteratorException(ref IntPtr pixelIterator1, ref ExceptionType exType2);
        

        [DllImport(LIB)]
        public static extern ExceptionType PixelGetIteratorExceptionType(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsPixelIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PixelClearIteratorException(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PixelSetIteratorRow(ref IntPtr pixelIterator1, IntPtr ssizetVal2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PixelSyncIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern IntPtr ClonePixelIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyPixelIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern IntPtr NewPixelIterator(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr NewPixelRegionIterator(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, UIntPtr sizetVal4, UIntPtr sizetVal5);
        

        [DllImport(LIB)]
        public static extern IntPtr PixelGetCurrentIteratorRow(ref IntPtr pixelIterator1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr PixelGetNextIteratorRow(ref IntPtr pixelIterator1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr PixelGetPreviousIteratorRow(ref IntPtr pixelIterator1, ref UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern UIntPtr PixelGetIteratorRow(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern void ClearPixelIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern void PixelResetIterator(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern void PixelSetFirstIteratorRow(ref IntPtr pixelIterator1);
        

        [DllImport(LIB)]
        public static extern void PixelSetLastIteratorRow(ref IntPtr pixelIterator1);
        


        // -------------------------------------------------------------------
        // pixel-wand.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr PixelGetColorAsNormalizedString(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr PixelGetColorAsString(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr PixelGetException(IntPtr pixelWand1, ref ExceptionType exType2);
        

        [DllImport(LIB)]
        public static extern double PixelGetAlpha(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetBlack(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetBlue(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetCyan(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetFuzz(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetGreen(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetMagenta(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetOpacity(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetRed(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern double PixelGetYellow(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern ExceptionType PixelGetExceptionType(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetIndex(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsPixelWand(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsPixelWandSimilar(IntPtr pixelWand1, IntPtr pixelWand2, [In] double val3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PixelClearException(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType PixelSetColor(IntPtr pixelWand1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern IntPtr ClonePixelWand(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr ClonePixelWands(IntPtr pixelWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyPixelWand(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyPixelWands(IntPtr pixelWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr NewPixelWand();
        

        [DllImport(LIB)]
        public static extern IntPtr NewPixelWands(UIntPtr sizetVal1);
        

        [DllImport(LIB)]
        public static extern float PixelGetAlphaQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetBlackQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetBlueQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetCyanQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetGreenQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetMagentaQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetOpacityQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetRedQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern float PixelGetYellowQuantum(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern UIntPtr PixelGetColorCount(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern void ClearPixelWand(IntPtr pixelWand1);
        

        [DllImport(LIB)]
        public static extern void PixelGetHSL(IntPtr pixelWand1, ref double val2, ref double val3, ref double val4);
        

        [DllImport(LIB)]
        public static extern void PixelGetMagickColor(IntPtr pixelWand1, ref PixelPacket pixelPacket2);
        

        [DllImport(LIB)]
        public static extern void PixelGetQuantumColor(IntPtr pixelWand1, ref PixelPacket pixelPacket2);
        

        [DllImport(LIB)]
        public static extern void PixelSetAlpha(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetAlphaQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetBlack(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetBlackQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetBlue(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetBlueQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetColorFromWand(IntPtr pixelWand1, IntPtr pixelWand2);
        

        [DllImport(LIB)]
        public static extern void PixelSetColorCount(IntPtr pixelWand1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern void PixelSetCyan(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetCyanQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetFuzz(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetGreen(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetGreenQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetHSL(IntPtr pixelWand1, [In] double val2, [In] double val3, [In] double val4);
        

        [DllImport(LIB)]
        public static extern void PixelSetIndex(IntPtr pixelWand1, float indexPacket2);
        

        [DllImport(LIB)]
        public static extern void PixelSetMagenta(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetMagentaQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetMagickColor(IntPtr pixelWand1, ref PixelPacket pixelPacket2);
        

        [DllImport(LIB)]
        public static extern void PixelSetOpacity(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetOpacityQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetQuantumColor(IntPtr pixelWand1, ref PixelPacket pixelPacket2);
        

        [DllImport(LIB)]
        public static extern void PixelSetRed(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetRedQuantum(IntPtr pixelWand1, float val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetYellow(IntPtr pixelWand1, [In] double val2);
        

        [DllImport(LIB)]
        public static extern void PixelSetYellowQuantum(IntPtr pixelWand1, float val2);
        


        // -------------------------------------------------------------------
        // stream.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern MagickBooleanType StreamImageCommand(IntPtr imageInfo1, int val2, [MarshalAs(UnmanagedType.LPStr)]string str3, [MarshalAs(UnmanagedType.LPStr)]string str4, IntPtr exceptionInfo5);
        


        // -------------------------------------------------------------------
        // wand-view.h
        // -------------------------------------------------------------------
        [DllImport(LIB)]
        public static extern IntPtr GetWandViewException(IntPtr wandView1, ref ExceptionType exType2);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType DuplexTransferWandViewIterator(IntPtr wandView1, IntPtr wandView2, IntPtr wandView3, IntPtr transferWandViewMethod4, IntPtr ptr5);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType GetWandViewIterator(IntPtr wandView1, IntPtr getWandViewMethod2, IntPtr ptr3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType IsWandView(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType SetWandViewIterator(IntPtr wandView1, IntPtr setWandViewMethod2, IntPtr ptr3);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType TransferWandViewIterator(IntPtr wandView1, IntPtr wandView2, IntPtr transferWandViewMethod3, IntPtr ptr4);
        

        [DllImport(LIB)]
        public static extern MagickBooleanType UpdateWandViewIterator(IntPtr wandView1, IntPtr updateWandViewMethod2, IntPtr ptr3);
        

        [DllImport(LIB)]
        public static extern IntPtr GetWandViewWand(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern IntPtr GetWandViewPixels(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern RectangleInfo GetWandViewExtent(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern void SetWandViewDescription(IntPtr wandView1, [MarshalAs(UnmanagedType.LPStr)]string str2);
        

        [DllImport(LIB)]
        public static extern void SetWandViewThreads(IntPtr wandView1, UIntPtr sizetVal2);
        

        [DllImport(LIB)]
        public static extern IntPtr CloneWandView(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern IntPtr DestroyWandView(IntPtr wandView1);
        

        [DllImport(LIB)]
        public static extern IntPtr NewWandView(IntPtr magickWand1);
        

        [DllImport(LIB)]
        public static extern IntPtr NewWandViewExtent(IntPtr magickWand1, IntPtr ssizetVal2, IntPtr ssizetVal3, UIntPtr sizetVal4, UIntPtr sizetVal5);
        


    }
}
