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
    if(type ~ /MagickBooleanType/) {
        return "MagickBooleanType";
    }
    
    if(type ~ /MagickWand\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /DrawInfo\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /Quantum/) {
        return "float";
    }
    
    if(type ~ /IndexPacket/) {
        return "float";
    }
    
    if(type ~ /size_t/) {
        return "UIntPtr";
    }
    
    if(type ~ /ssize_t/) {
        return "IntPtr";
    }
    
    if(type ~ /const\s*char\s*\*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /const\s*char\s*\*/) {
        return "string";
    }
    
    if(type ~ /char\s*\*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /char\s*\*/) {
        return "string";
    }
    
    if(type ~ /void\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /DrawingWand\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /PixelWand\s*\*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /PixelWand\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /ImageInfo\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /double\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~/ChannelFeatures\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~/ChannelStatistics\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~/MagickCommand/) {
        return "IntPtr";
    }
    
    if(type ~ /Image\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /unsigned\s*\*/) {
        return "UIntPtr";
    }
    
    if(type ~ /PixelIterator\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /MagickSizeType/) {
        return "IntPtr";
    }
    
    if(type ~ /WandView\s*\*/) {
        return "IntPtr";
    }
    
    if(type ~ /MagickProgressMonitor/) {
        return "IntPtr";
    }
    
    if(type ~ /ColorPacket\s*\*/) {
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
    gsub(/const\s*/, "", type);
    
    if(type ~ /MagickBooleanType/) {
        return "MagickBooleanType val" i;
    }
    
    if(type ~ /MagickWand\s*\*/) {
        return "IntPtr magickWand" i;
    }
    
    if(type ~ /ssize_t/) {
        return "IntPtr ssizetVal" i;
    }
    
    if(type ~ /size_t/) {
        return "UIntPtr sizetVal" i;
    }
    
    if(type ~ /Image\s*\*/) {
        return "IntPtr image" i;
    }
    
    if(type ~ /char\s*\*/) {
        return "[MarshalAs(UnmanagedType.LPStr)]string str" i;
    }
    
    if(type ~ /ExceptionType\s*\*/) {
        return "ref ExceptionType exType" i;
    }

    if(type ~ /PixelPacket\s*\*/) {
        return "ref PixelPacket pixelPacket" i;
    }
    
    if(type ~ /void\s*\*/) {
        return "IntPtr ptr" i;
    }
    
    if(type ~ /void/) {
        return "";
    }
    
    if(type ~ /DrawingWand\s*\*/) {
        return "IntPtr drawingWand" i;
    }
    
    if(type ~ /PixelWand\s*\*/) {
        return "IntPtr pixelWand" i;
    }
    
    if(type ~ /ExceptionInfo\s*\*/) {
        return "IntPtr exceptionInfo" i;
    }
    
    if(type ~ /ImageInfo\s*\*/) {
        return "IntPtr imageInfo" i;
    }
    
    if(type ~ /CompositeOperator/) {
        return "CompositeOperator op" i;
    }
    
    if(type ~ /DrawInfo\s*\*/) {
        return "IntPtr drawInfo" i;
    }
    
    if(type ~ /double\s*\*/) {
        return "ref double val" i;
    }
    
    if(type ~ /AffineMatrix\s*\*/) {
        return "ref AffineMatrix affineMatrix" i; 
    }
    
    if(type ~ /PointInfo\s*\*/) {
        return "ref PointInfo pointInfo" i;
    }
    
    if(type ~ /KernelInfo\s*\*/) {
        return "ref KernelInfo kernelInfo" i;
    }
    
    if(type ~ /MagickSizeType\s*\*/) {
        return "ref IntPtr magickSizeTypePtr" i;
    }
    
    if(type ~ /MagickSizeType/) {
        return "IntPtr magicSizeType" i;
    }
    
    if(type ~ /FILE\s*\*/) {
        return "IntPtr file" i;
    }
    
    if(type ~ /Quantum/) {
        return "float val" i;
    }
    
    if(type ~ /PixelIterator\s*\*/) {
        return "ref IntPtr pixelIterator" i;
    }
    
    if(type ~ /WandView\s*\*/) {
        return "IntPtr wandView" i;
    }
    
    if(type ~ /SetWandViewMethod/) {
        return "IntPtr setWandViewMethod" i;
    }
    
    if(type ~ /UpdateWandViewMethod/) {
        return "IntPtr updateWandViewMethod" i;
    }
    
    if(type ~ /TransferWandViewMethod/) {
        return "IntPtr transferWandViewMethod" i;
    }
    
    if(type ~ /GetWandViewMethod/) {
        return "IntPtr getWandViewMethod" i;
    }
    
    if(type ~ /MagickProgressMonitor/) {
        return "IntPtr mon" i;
    }
    
    if(type ~ /RectangleInfo\s*\*/) {
        return "ref RectangleInfo rectangleInfo" i;
    }
    
    if(type ~ /IndexPacket/) {
        return "float indexPacket" i;
    }
    
    if(type ~ /MagickCommand/) {
        return "IntPtr magickCommand" i;
    }
    
    split(type, arr, " ", seps);
    
    if(length(arr) > 1) {
        return type;
    }
    
    return type " val" i;
}
