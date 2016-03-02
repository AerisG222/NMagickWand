using System;
using System.Collections.Generic;
using System.Linq;


namespace NMagickWand
{
    public class DrawingWand
        : IDisposable
    {
        internal IntPtr Wand { get; set; }


        public PixelWand BorderColor
        {
            get
            {
                var pw = new PixelWand();

                MagickWandApi.DrawGetBorderColor(Wand, pw.Wand);

                return pw;
            }
            set
            {
                MagickWandApi.DrawSetBorderColor(Wand, value.Wand);
            }
        }


        public string ClipPath
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetClipPath(Wand));
            }
            set
            {
                MagickWandApi.DrawSetClipPath(Wand, value);
            }
        }


        public FillRule ClipRule
        {
            get
            {
                return MagickWandApi.DrawGetClipRule(Wand);
            }
            set
            {
                MagickWandApi.DrawSetClipRule(Wand, value);
            }
        }


        public ClipPathUnits ClipUnits
        {
            get
            {
                return MagickWandApi.DrawGetClipUnits(Wand);
            }
            set
            {
                MagickWandApi.DrawSetClipUnits(Wand, value);
            }
        }


        public string Density
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetDensity(Wand));
            }
            set
            {
                MagickWandApi.DrawSetDensity(Wand, value);
            }
        }


        public PixelWand FillColor
        {
            get
            {
                var pw = new PixelWand();
                MagickWandApi.DrawGetFillColor(Wand, pw.Wand);
                return pw;
            }
            set
            {
                MagickWandApi.DrawSetFillColor(Wand, value.Wand);
            }
        }


        public double FillOpacity
        {
            get
            {
                return MagickWandApi.DrawGetFillOpacity(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFillOpacity(Wand, value);
            }
        }


        public FillRule FillRule
        {
            get
            {
                return MagickWandApi.DrawGetFillRule(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFillRule(Wand, value);
            }
        }


        public string Font
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetFont(Wand));
            }
            set
            {
                MagickWandApi.DrawSetFont(Wand, value);
            }
        }


        public string FontFamily
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetFontFamily(Wand));
            }
            set
            {
                MagickWandApi.DrawSetFontFamily(Wand, value);
            }
        }


        public double FontSize
        {
            get
            {
                return MagickWandApi.DrawGetFontSize(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFontSize(Wand, value);
            }
        }


        public StretchType FontStretch
        {
            get
            {
                return MagickWandApi.DrawGetFontStretch(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFontStretch(Wand, value);
            }
        }


        public StyleType FontStyle
        {
            get
            {
                return MagickWandApi.DrawGetFontStyle(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFontStyle(Wand, value);
            }
        }


        public uint FontWeight
        {
            get
            {
                return (uint)MagickWandApi.DrawGetFontWeight(Wand);
            }
            set
            {
                MagickWandApi.DrawSetFontWeight(Wand, (UIntPtr)value);
            }
        }


        public GravityType Gravity
        {
            get
            {
                return MagickWandApi.DrawGetGravity(Wand);
            }
            set
            {
                MagickWandApi.DrawSetGravity(Wand, value);
            }
        }


        public bool IsDrawingWand
        {
            get
            {
                return MagickWandApi.IsDrawingWand(Wand) == MagickBooleanType.True;
            }
        }


        public double Opacity
        {
            get
            {
                return MagickWandApi.DrawGetOpacity(Wand);
            }
            set
            {
                MagickWandApi.DrawSetOpacity(Wand, value);
            }
        }


        public bool StrokeAntialias
        {
            get
            {
                return MagickWandApi.DrawGetStrokeAntialias(Wand) == MagickBooleanType.True;
            }
            set
            {
                var a = value ? MagickBooleanType.True : MagickBooleanType.False;
                MagickWandApi.DrawSetStrokeAntialias(Wand, a);
            }
        }


        public PixelWand StrokeColor
        {
            get
            {
                var pw = new PixelWand();
                MagickWandApi.DrawGetStrokeColor(Wand, pw.Wand);
                return pw;
            }
            set
            {
                MagickWandApi.DrawSetStrokeColor(Wand, value.Wand);
            }
        }


        public IReadOnlyList<double> StrokeDashArray
        {
            get
            {
                return MagickHelper.ExecuteMagickWandDoubleList(Wand, MagickWandApi.DrawGetStrokeDashArray);
            }
            set
            {
                MagickWandApi.DrawSetStrokeDashArray(Wand, (UIntPtr)value.Count, value.ToArray());
            }
        }


        public double StrokeDashOffset
        {
            get
            {
                return MagickWandApi.DrawGetStrokeDashOffset(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeDashOffset(Wand, value);
            }
        }


        public LineCap StrokeLineCap
        {
            get
            {
                return MagickWandApi.DrawGetStrokeLineCap(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeLineCap(Wand, value);
            }
        }


        public LineJoin StrokeLineJoin
        {
            get
            {
                return MagickWandApi.DrawGetStrokeLineJoin(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeLineJoin(Wand, value);
            }
        }


        public uint StrokeMiterLimit
        {
            get
            {
                return (uint)MagickWandApi.DrawGetStrokeMiterLimit(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeMiterLimit(Wand, (UIntPtr)value);
            }
        }


        public double StrokeOpacity
        {
            get
            {
                return MagickWandApi.DrawGetStrokeOpacity(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeOpacity(Wand, value);
            }
        }


        public double StrokeWidth
        {
            get
            {
                return MagickWandApi.DrawGetStrokeWidth(Wand);
            }
            set
            {
                MagickWandApi.DrawSetStrokeWidth(Wand, value);
            }
        }


        public AlignType TextAlignment
        {
            get
            {
                return MagickWandApi.DrawGetTextAlignment(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextAlignment(Wand, value);
            }
        }


        public bool TextAntialias
        {
            get
            {
                return MagickWandApi.DrawGetTextAntialias(Wand) == MagickBooleanType.True;
            }
            set
            {
                var a = value ? MagickBooleanType.True : MagickBooleanType.False;
                MagickWandApi.DrawSetTextAntialias(Wand, a);
            }
        }


        public DecorationType TextDecoration
        {
            get
            {
                return MagickWandApi.DrawGetTextDecoration(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextDecoration(Wand, value);
            }
        }


        public DirectionType TextDirection
        {
            get
            {
                return MagickWandApi.DrawGetTextDirection(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextDirection(Wand, value);
            }
        }


        public string TextEncoding
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetTextEncoding(Wand));
            }
            set
            {
                MagickWandApi.DrawSetTextEncoding(Wand, value);
            }
        }


        public double TextKerning
        {
            get
            {
                return MagickWandApi.DrawGetTextKerning(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextKerning(Wand, value);
            }
        }


        public double TextInterlineSpacing
        {
            get
            {
                return MagickWandApi.DrawGetTextInterlineSpacing(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextInterlineSpacing(Wand, value);
            }
        }


        public double TextInterwordSpacing
        {
            get
            {
                return MagickWandApi.DrawGetTextInterwordSpacing(Wand);
            }
            set
            {
                MagickWandApi.DrawSetTextInterwordSpacing(Wand, value);
            }
        }


        public string VectorGraphics
        {
            get
            {
                return MagickHelper.GetMagickString(MagickWandApi.DrawGetVectorGraphics(Wand));
            }
            set
            {
                MagickWandApi.DrawSetVectorGraphics(Wand, value);
            }
        }


        public PixelWand TextUnderColor
        {
            get
            {
                var pw = new PixelWand();

                MagickWandApi.DrawGetTextUnderColor(Wand, pw.Wand);

                return pw;
            }
            set
            {
                MagickWandApi.DrawSetTextUnderColor(Wand, value.Wand);
            }
        }


        public DrawingWand()
        {
            Wand = MagickWandApi.NewDrawingWand();
        }


        internal DrawingWand(IntPtr drawingWand)
        {
            Wand = drawingWand;
        }


        public void Clear()
        {
            MagickWandApi.ClearDrawingWand(Wand);
        }


        public DrawingWand Clone()
        {
            return new DrawingWand(MagickWandApi.CloneDrawingWand(Wand));
        }


        public void DrawAffine(AffineMatrix affine)
        {
            MagickWandApi.DrawAffine(Wand, ref affine);
        }


        public void DrawAnnotation(double x, double y, string text)
        {
            MagickWandApi.DrawAnnotation(Wand, x, y, text);
        }


        public void DrawArc(double sx, double sy, double ex, double ey, double sd, double ed)
        {
            MagickWandApi.DrawArc(Wand, sx, sy, ex, ey, sd, ed);
        }


        public void DrawBezier(IReadOnlyList<PointInfo> points)
        {
            throw new NotImplementedException();
        }


        public void DrawCircle(double ox, double oy, double px, double py)
        {
            MagickWandApi.DrawCircle(Wand, ox, oy, px, py);
        }


        public void DrawColor(double x, double y, PaintMethod method)
        {
            MagickWandApi.DrawColor(Wand, x, y, method);
        }


        public void DrawComment(string comment)
        {
            MagickWandApi.DrawComment(Wand, comment);
        }


        public void DrawComposite(CompositeOperator compose, double x, double y, double width, double height, MagickWand magickWand)
        {
            Check(MagickWandApi.DrawComposite(Wand, compose, x, y, width, height, magickWand.Wand));
        }


        public void DrawEllipse(double ox, double oy, double rx, double ry, double start, double end)
        {
            MagickWandApi.DrawEllipse(Wand, ox, oy, rx, ry, start, end);
        }


        public void DrawLine(double sx, double sy, double ex, double ey)
        {
            MagickWandApi.DrawLine(Wand, sx, sy, ex, ey);
        }


        public void DrawMatte(double x, double y, PaintMethod method)
        {
            MagickWandApi.DrawMatte(Wand, x, y, method);
        }


        public void DrawPathClose()
        {
            MagickWandApi.DrawPathClose(Wand);
        }


        public void DrawPathCurveToAbsolute(double x1, double y1, double x2, double y2, double x, double y)
        {
            MagickWandApi.DrawPathCurveToAbsolute(Wand, x1, y1, x2, y2, x, y);
        }


        public void GetFontResolution(out double x, out double y)
        {
            Check(MagickWandApi.DrawGetFontResolution(Wand, out x, out y));
        }


        public void DrawPathCurveToRelative(double x1, double y1, double x2, double y2, double x, double y)
        {
            MagickWandApi.DrawPathCurveToRelative(Wand, x1, y1, x2, y2, x, y);
        }


        public void DrawPathCurveToQuadraticBezierAbsolute(double x1, double y1, double x, double y)
        {
            MagickWandApi.DrawPathCurveToQuadraticBezierAbsolute(Wand, x1, y1, x, y);
        }


        public void DrawPathCurveToQuadraticBezierRelative(double x1, double y1, double x, double y)
        {
            MagickWandApi.DrawPathCurveToQuadraticBezierRelative(Wand, x1, y1, x, y);
        }


        public void DrawPathCurveToQuadraticBezierSmoothAbsolute(double x, double y)
        {
            MagickWandApi.DrawPathCurveToQuadraticBezierSmoothAbsolute(Wand, x, y);
        }


        public void DrawPathCurveToQuadraticBezierSmoothRelative(double x, double y)
        {
            MagickWandApi.DrawPathCurveToQuadraticBezierSmoothRelative(Wand, x, y);
        }


        public void DrawPathCurveToSmoothAbsolute(double x2, double y2, double x, double y)
        {
            MagickWandApi.DrawPathCurveToSmoothAbsolute(Wand, x2, y2, x, y);
        }


        public void DrawPathCurveToSmoothRelative(double x2, double y2, double x, double y)
        {
            MagickWandApi.DrawPathCurveToSmoothRelative(Wand, x2, y2, x, y);
        }


        public void DrawPathEllipticArcAbsolute(double rx, double ry, double xAxisRotation, bool largeArcFlag, bool sweepFlag, double x, double y)
        {
            var arc = largeArcFlag ? MagickBooleanType.True : MagickBooleanType.False;
            var sweep = sweepFlag ? MagickBooleanType.True : MagickBooleanType.False;

            MagickWandApi.DrawPathEllipticArcAbsolute(Wand, rx, ry, xAxisRotation, arc, sweep, x, y);
        }


        public void DrawPathEllipticArcRelative(double rx, double ry, double xAxisRotation, bool largeArcFlag, bool sweepFlag, double x, double y)
        {
            var arc = largeArcFlag ? MagickBooleanType.True : MagickBooleanType.False;
            var sweep = sweepFlag ? MagickBooleanType.True : MagickBooleanType.False;

            MagickWandApi.DrawPathEllipticArcRelative(Wand, rx, ry, xAxisRotation, arc, sweep, x, y);
        }


        public void DrawPathFinish()
        {
            MagickWandApi.DrawPathFinish(Wand);
        }


        public void DrawPathLineToAbsolute(double x, double y)
        {
            MagickWandApi.DrawPathLineToAbsolute(Wand, x, y);
        }


        public void DrawPathLineToRelative(double x, double y)
        {
            MagickWandApi.DrawPathLineToRelative(Wand, x, y);
        }


        public void DrawPathLineToHorizontalAbsolute(double x)
        {
            MagickWandApi.DrawPathLineToHorizontalAbsolute(Wand, x);
        }


        public void DrawPathLineToHorizontalRelative(double x)
        {
            MagickWandApi.DrawPathLineToHorizontalRelative(Wand, x);
        }


        public void DrawPathLineToVerticalAbsolute(double y)
        {
            MagickWandApi.DrawPathLineToVerticalAbsolute(Wand, y);
        }


        public void DrawPathLineToVerticalRelative(double y)
        {
            MagickWandApi.DrawPathLineToVerticalRelative(Wand, y);
        }


        public void DrawPathMoveToAbsolute(double x, double y)
        {
            MagickWandApi.DrawPathMoveToAbsolute(Wand, x, y);
        }


        public void DrawPathMoveToRelative(double x, double y)
        {
            MagickWandApi.DrawPathMoveToRelative(Wand, x, y);
        }


        public void DrawPathStart()
        {
            MagickWandApi.DrawPathStart(Wand);
        }


        public void DrawPoint(double x, double y)
        {
            MagickWandApi.DrawPoint(Wand, x, y);
        }


        public void DrawPolygon(IReadOnlyList<PointInfo> points)
        {
            throw new NotImplementedException();
        }


        public void DrawPolyline(IReadOnlyList<PointInfo> points)
        {
            throw new NotImplementedException();
        }


        public void PopClipPath()
        {
            MagickWandApi.DrawPopClipPath(Wand);
        }


        public void PopDefs()
        {
            MagickWandApi.DrawPopDefs(Wand);
        }


        public void PopDrawingWand()
        {
            MagickWandApi.PopDrawingWand(Wand);
        }


        public void PopPattern()
        {
            Check(MagickWandApi.DrawPopPattern(Wand));
        }


        public void PushClipPath(string clipMaskId)
        {
            MagickWandApi.DrawPushClipPath(Wand, clipMaskId);
        }


        public void PushDefs()
        {
            MagickWandApi.DrawPushDefs(Wand);
        }


        public void PushDrawingWand()
        {
            MagickWandApi.PushDrawingWand(Wand);
        }


        public void PushPattern(string pattern, double x, double y, double width, double height)
        {
            Check(MagickWandApi.DrawPushPattern(Wand, pattern, x, y, width, height));
        }


        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            MagickWandApi.DrawRectangle(Wand, x1, y1, x2, y2);
        }


        public void PeekDrawingWand()
        {
            throw new NotImplementedException();
        }


        public void ResetVectorGraphics()
        {
            MagickWandApi.DrawResetVectorGraphics(Wand);
        }


        public void Rotate(double degrees)
        {
            MagickWandApi.DrawRotate(Wand, degrees);
        }


        public void DrawRoundRectangle(double x1, double y1, double x2, double y2, double rx, double ry)
        {
            MagickWandApi.DrawRoundRectangle(Wand, x1, y1, x2, y2, rx, ry);
        }


        public void Scale(double x, double y)
        {
            MagickWandApi.DrawScale(Wand, x, y);
        }


        public void SetFontResolution(double xResolution, double yResolution)
        {
            MagickWandApi.DrawSetFontResolution(Wand, xResolution, yResolution);
        }


        public void SetFillPatternUrl(string url)
        {
            MagickWandApi.DrawSetFillPatternURL(Wand, url);
        }


        public void SetStrokePatternUrl(string url)
        {
            MagickWandApi.DrawSetStrokePatternURL(Wand, url);
        }


        public void SetVectorGraphics(string xml)
        {
            MagickWandApi.DrawSetVectorGraphics(Wand, xml);
        }


        public void SetViewBox(int x1, int y1, int x2, int y2)
        {
            MagickWandApi.DrawSetViewbox(Wand, (IntPtr)x1, (IntPtr)y1, (IntPtr)x2, (IntPtr)y2);
        }


        public void SkewX(double degrees)
        {
            MagickWandApi.DrawSkewX(Wand, degrees);
        }


        public void SkewY(double degrees)
        {
            MagickWandApi.DrawSkewY(Wand, degrees);
        }


        public void Translate(double x, double y)
        {
            MagickWandApi.DrawTranslate(Wand, x, y);
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
            var msgPtr = MagickWandApi.DrawGetException(Wand, ref exType);

            if(exType != ExceptionType.UndefinedException)
            {
                var msg = MagickHelper.GetMagickString(msgPtr);

                MagickWandApi.MagickRelinquishMemory(msgPtr);
                MagickWandApi.DrawClearException(Wand);

                throw new MagickWandException(exType, msg);
            }
        }


        ~DrawingWand()
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
                MagickWandApi.DestroyDrawingWand(Wand);

                Wand = IntPtr.Zero;
            }
        }
    }
}
