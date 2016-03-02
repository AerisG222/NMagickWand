BEGIN {
    inexp=0;
    return_type="";
}
{
    if(inexp == 1) {
        line = $0;
        gsub(/^\s+/, "", line);

        # read function defs that continue onto the next line as needed
        while(line !~ /).$/) {
            getline nextline;
            gsub(/^\s+/, "", nextline);
            line = line nextline;
        }

        # end of function, end of return type
        if(line ~ /);$/) {
            inexp = 0;
            gsub(/;$/, "", line);
        }

        # end of function, not end of return type
        if(line ~ /),$/) {
            gsub(/,$/, "", line);
        }

        decl = getdecl(return_type, line);

        print "        [DllImport(LIB)]";

        if(decl ~ /^string\s+/) {
            print "        [return: MarshalAs(UnmanagedType.LPStr)]";
        }

        print "        public static extern " decl;
        print "        \n";
    }
    if($0 ~ /extern WandExport/) {
        inexp = 1;
        return_type = $3;

        if($4 != "") {
            return_type = return_type " " $4;
        }
        if($5 != "") {
            return_type = return_type " " $5;
        }
    }
}
function getdecl(return_type, fn) {
    if(fn ~ /^\*\*/) {
        return_type = return_type " **";
        gsub(/^\*\*/, "", fn);
    }
    else if(fn ~ /^\*/) {
        return_type = return_type " *";
        gsub(/^\*/, "", fn);
    }

    return cleanreturn(return_type) " " cleanline(fn);
}
function cleanreturn(type) {
    if(type ~/ChannelFeatures\s*\*/) {
        return "IntPtr";
    }

    if(type ~/ChannelStatistics\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /const\s*char\s*\*\*/) {
        return "IntPtr";
    }

    if(type ~ /const\s*char\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /char\s*\*\*/) {
        return "IntPtr";
    }

    if(type ~ /char\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /double\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /ColorPacket\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /DrawInfo\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /DrawingWand\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /Image\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /ImageInfo\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /IndexPacket/) {
        return "float";
    }

    if(type ~ /MagickBooleanType/) {
        return "MagickBooleanType";
    }

    if(type ~/MagickCommand/) {
        return "IntPtr";
    }

    if(type ~ /MagickProgressMonitor/) {
        return "IntPtr";
    }

    if(type ~ /MagickSizeType/) {
        return "UIntPtr";
    }

    if(type ~ /MagickWand\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /PixelIterator\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /PixelWand\s*\*\*/) {
        return "IntPtr";
    }

    if(type ~ /PixelWand\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /Quantum/) {
        return "float";
    }

    if(type ~ /size_t/) {
        return "UIntPtr";
    }

    if(type ~ /ssize_t/) {
        return "IntPtr";
    }

    if(type ~ /unsigned\s*\*/) {
        return "UIntPtr";
    }

    if(type ~ /void\s*\*/) {
        return "IntPtr";
    }

    if(type ~ /WandView\s*\*/) {
        return "IntPtr";
    }

    return type;
}
function cleanline(line) {
    gsub(/^*/, "", line);
    split(line, arr, "(", seps);
    fnname = arr[1];
    arglist = "";

    split(arr[2], allargs, ")", seps);
    split(allargs[1], args, ",", seps);

    for(i in args) {
        if(length(arglist) > 0) {
            arglist = arglist ", ";
        }

        arglist = arglist cleanarg(i, args[i]);
    }

    decl = fnname "(" arglist ");";

    return decl;
}
function cleanarg(i, type) {
    if(type ~ /AffineMatrix\s*\*/) {
        return "ref AffineMatrix affineMatrix" i;
    }

    if(type ~ /const AlphaChannelType/) {
        return "[In] AlphaChannelType alphaChannelType" i;
    }

    if(type ~ /const AlignType/) {
        return "[In] AlignType alignType" i;
    }

    if(type ~ /char\s*\*/) {
        return "[MarshalAs(UnmanagedType.LPStr)]string str" i;
    }

    if(type ~ /const ChannelType/) {
        return "[In] ChannelType channelType" i;
    }

    if(type ~ /const ClipPathUnits/) {
        return "[In] ClipPathUnits clipPathUnits" i;
    }

    if(type ~ /const ColorspaceType/) {
        return "[In] ColorspaceType colorspaceType" i;
    }

    if(type ~ /CompositeOperator/) {
        return "CompositeOperator op" i;
    }

    if(type ~ /const CompressionType/) {
        return "CompressionType compressionType" i;
    }

    if(type ~ /const DecorationType/) {
        return "[In] DecorationType decorationType" i;
    }

    if(type ~ /const DirectionType/) {
        return "[In] DirectionType directionType" i;
    }

    if(type ~ /const DisposeType/) {
        return "DisposeType disposeType" i;
    }

    if(type ~ /const DistortImageMethod/) {
        return "[In] DistortImageMethod distortImageMethod" i;
    }

    if(type ~ /const DitherMethod/) {
        return "[In] DitherMethod ditherMethod" i;
    }

    if(type ~ /DrawInfo\s*\*/) {
        return "IntPtr drawInfo" i;
    }

    if(type ~ /const double\s*\*/) {
        return "double[] val" i;
    }

    if(type ~ /const double/) {
        return "[In] double val" i;
    }

    if(type ~ /double\s*\*/) {
        return "out double val" i;
    }

    if(type ~ /DrawingWand\s*\*/) {
        return "IntPtr drawingWand" i;
    }

    if(type ~ /const EndianType/) {
        return "[In] EndianType endianType" i;
    }

    if(type ~ /ExceptionInfo\s*\*/) {
        return "IntPtr exceptionInfo" i;
    }

    if(type ~ /ExceptionType\s*\*/) {
        return "ref ExceptionType exType" i;
    }

    if(type ~ /FILE\s*\*/) {
        return "IntPtr file" i;
    }

    if(type ~ /const FillRule/) {
        return "[In] FillRule fillRule" i;
    }

    if(type ~ /const FilterTypes/) {
        return "[In] FilterTypes filterTypes" i;
    }

    if(type ~ /GetWandViewMethod/) {
        return "IntPtr getWandViewMethod" i;
    }

    if(type ~ /const GravityType/) {
        return "[In] GravityType gravityType" i;
    }

    if(type ~ /Image\s*\*/) {
        return "IntPtr image" i;
    }

    if(type ~ /ImageInfo\s*\*/) {
        return "IntPtr imageInfo" i;
    }

    if(type ~ /const ImageLayerMethod/) {
        return "[In] ImageLayerMethod imageLayerMethod" i;
    }

    if(type ~ /const ImageType/) {
        return "[In] ImageType imageType" i;
    }

    if(type ~ /IndexPacket/) {
        return "float indexPacket" i;
    }

    if(type ~ /const int/) {
        return "[In] int val" i;
    }

    if(type ~ /const InterlaceType/) {
        return "[In] InterlaceType interlaceType" i;
    }

    if(type ~ /const InterpolatePixelMethod/) {
        return "[In] InterpolatePixelMethod interpolatePixelMethod" i;
    }

    if(type ~ /KernelInfo\s*\*/) {
        return "ref KernelInfo kernelInfo" i;
    }

    if(type ~ /const LineCap/) {
        return "[In] LineCap lineCap" i;
    }

    if(type ~ /const LineJoin/) {
        return "[In] LineJoin lineJoin" i;
    }

    if(type ~ /MagickBooleanType/) {
        return "MagickBooleanType val" i;
    }

    if(type ~ /MagickCommand/) {
        return "IntPtr magickCommand" i;
    }

    if(type ~ /const MagickEvaluateOperator/) {
        return "[In] MagickEvaluateOperator magickEvaluateOperator" i;
    }

    if(type ~ /const MagickFunction/) {
        return "[In] MagickFunction magickFunction" i;
    }

    if(type ~ /MagickProgressMonitor/) {
        return "IntPtr mon" i;
    }

    if(type ~ /MagickSizeType\s*\*/) {
        return "out UIntPtr magickSizeTypePtr" i;
    }

    if(type ~ /MagickSizeType/) {
        return "UIntPtr magicSizeType" i;
    }

    if(type ~ /MagickWand\s*\*/) {
        return "IntPtr magickWand" i;
    }

    if(type ~ /const MetricType/) {
        return "[In] MetricType metricType" i;
    }

    if(type ~ /const MontageMode/) {
        return "[In] MontageMode montageMode" i;
    }

    if(type ~ /const NoiseType/) {
        return "[In] NoiseType noiseType" i;
    }

    if(type ~ /const OrientationType/) {
        return "[In] OrientationType orientationType" i;
    }

    if(type ~ /PaintMethod/) {
        return "[In] PaintMethod paintMethod" i;
    }

    if(type ~ /PixelIterator\s*\*/) {
        return "IntPtr pixelIterator" i;
    }

    if(type ~ /PixelPacket\s*\*/) {
        return "ref PixelPacket pixelPacket" i;
    }

    if(type ~ /PixelWand\s*\*/) {
        return "IntPtr pixelWand" i;
    }

    if(type ~ /PointInfo\s*\*/) {
        return "ref PointInfo pointInfo" i;
    }

    if(type ~ /const PreviewType/) {
        return "[In] PreviewType previewType" i;
    }

    if(type ~ /Quantum/) {
        return "float val" i;
    }

    if(type ~ /RectangleInfo\s*\*/) {
        return "ref RectangleInfo rectangleInfo" i;
    }

    if(type ~ /const RenderingIntent/) {
        return "[In] RenderingIntent renderingIntent" i;
    }

    if(type ~ /const ResolutionType/) {
        return "[In] ResolutionType resolutionType" i;
    }

    if(type ~ /const ResourceType/) {
        return "[In] ResourceType resourceType" i;
    }

    if(type ~ /SetWandViewMethod/) {
        return "IntPtr setWandViewMethod" i;
    }

    if(type ~ /ssize_t\s*\*/) {
        return "out IntPtr ssizetVal" i;
    }

    if(type ~ /ssize_t/) {
        return "IntPtr ssizetVal" i;
    }

    if(type ~ /size_t\s*\*/) {
        return "out UIntPtr sizetVal" i;
    }

    if(type ~ /size_t/) {
        return "UIntPtr sizetVal" i;
    }

    if(type ~ /const SparseColorMethod/) {
        return "[In] SparseColorMethod sparseColorMethod" i;
    }

    if(type ~ /const StatisticType/) {
        return "[In] StatisticType statisticType" i;
    }

    if(type ~ /const StorageType/) {
        return "[In] StorageType storageType" i;
    }

    if(type ~ /const StretchType/) {
        return "[In] StretchType stretchType" i;
    }

    if(type ~ /const StyleType/) {
        return "[In] StyleType styleType" i;
    }

    if(type ~ /TransferWandViewMethod/) {
        return "IntPtr transferWandViewMethod" i;
    }

    if(type ~ /UpdateWandViewMethod/) {
        return "IntPtr updateWandViewMethod" i;
    }

    if(type ~ /const VirtualPixelMethod/) {
        return "[In] VirtualPixelMethod virtualPixelMethod" i;
    }

    if(type ~ /void\s*\*/) {
        return "IntPtr ptr" i;
    }

    if(type ~ /void/) {
        return "";
    }

    if(type ~ /WandView\s*\*/) {
        return "IntPtr wandView" i;
    }

    split(type, arr, " ", seps);

    if(length(arr) > 1) {
        return type;
    }

    return type " val" i;
}
