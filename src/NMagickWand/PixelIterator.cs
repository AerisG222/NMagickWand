using System;
using System.Collections.Generic;


namespace NMagickWand
{
    public class PixelIterator
        : IDisposable
    {
        internal IntPtr Iterator { get; set; }


        public bool IsPixelIterator
        {
            get
            {
                return MagickWandApi.IsPixelIterator(Iterator) == MagickBooleanType.True;
            }
        }


        public PixelIterator(MagickWand wand)
        {
            Iterator = MagickWandApi.NewPixelIterator(wand.Wand);
        }


        internal PixelIterator(IntPtr iterator)
        {
            Iterator = iterator;
        }


        public void Clear()
        {
            MagickWandApi.ClearPixelIterator(Iterator);
        }


        public PixelIterator Clone()
        {
            return new PixelIterator(MagickWandApi.ClonePixelIterator(Iterator));
        }


        public PixelIterator NewRegionIterator(MagickWand wand, int x, int y, uint width, uint height)
        {
            return new PixelIterator(MagickWandApi.NewPixelRegionIterator(wand.Wand, (IntPtr)x, (IntPtr)y, (UIntPtr)width, (UIntPtr)height));
        }


        public IReadOnlyList<PixelWand> GetCurrentIteratorRow()
        {
            return MagickHelper.ExecuteMagickWandPixelWandList(Iterator, MagickWandApi.PixelGetCurrentIteratorRow);
        }


        public uint GetIteratorRow()
        {
            return (uint)MagickWandApi.PixelGetIteratorRow(Iterator);
        }


        public IReadOnlyList<PixelWand> GetNextIteratorRow()
        {
            return MagickHelper.ExecuteMagickWandPixelWandList(Iterator, MagickWandApi.PixelGetNextIteratorRow);
        }


        public IReadOnlyList<PixelWand> GetPreviousIteratorRow()
        {
            return MagickHelper.ExecuteMagickWandPixelWandList(Iterator, MagickWandApi.PixelGetPreviousIteratorRow);
        }


        public void ResetIterator()
        {
            MagickWandApi.PixelResetIterator(Iterator);
        }


        public void SetFirstIteratorRow()
        {
            MagickWandApi.PixelSetFirstIteratorRow(Iterator);
        }


        public void SetIteratorRow(int row)
        {
            Check(MagickWandApi.PixelSetIteratorRow(Iterator, (IntPtr)row));
        }


        public void SetLastIteratorRow()
        {
            MagickWandApi.PixelSetLastIteratorRow(Iterator);
        }


        public void SyncIterator()
        {
            Check(MagickWandApi.PixelSyncIterator(Iterator));
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
            var msgPtr = MagickWandApi.PixelGetIteratorException(Iterator, ref exType);

            if(exType != ExceptionType.UndefinedException)
            {
                var msg = MagickHelper.GetMagickString(msgPtr);

                MagickWandApi.MagickRelinquishMemory(msgPtr);
                MagickWandApi.PixelClearIteratorException(Iterator);

                throw new MagickWandException(exType, msg);
            }
        }


        ~PixelIterator()
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
            if(Iterator != IntPtr.Zero)
            {
                MagickWandApi.DestroyPixelIterator(Iterator);

                Iterator = IntPtr.Zero;
            }
        }
    }
}
