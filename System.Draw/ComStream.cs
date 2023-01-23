namespace System.Draw;
    
    
    
    
class ComStream : InfraObject, IStream
{
    public Stream Stream { get; set; }



    public void Clone(out IStream ppstm)
    {
        throw new NotImplementedException();
    }

    public void Commit(int grfCommitFlags)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
    {
        throw new NotImplementedException();
    }

    public void LockRegion(long libOffset, long cb, int dwLockType)
    {
        throw new NotImplementedException();
    }


    public void Read(byte[] pv, int cb, IntPtr pcbRead)
    {
        int u;

        
        u = this.Stream.Read(pv, 0, cb);



        if (!(pcbRead == IntPtr.Zero))
        {
            Marshal.WriteInt64(pcbRead, u);
        }
    }



    public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
    {
        SeekOrigin origin;
        

        origin = (SeekOrigin)dwOrigin;
        

        long pos = this.Stream.Seek(dlibMove, origin);
        

        if (!(plibNewPosition == IntPtr.Zero))
        {
            Marshal.WriteInt64(plibNewPosition, pos);
        }
    }
    



    public void Stat(out Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag)
    {
        return;
    }






    public void Write(byte[] pv, int cb, IntPtr pcbWritten)
    {
        throw new NotImplementedException();
    }




    public void Revert()
    {
        throw new NotImplementedException();
    }



    public void SetSize(long libNewSize)
    {
        throw new NotImplementedException();
    }


    public void UnlockRegion(long libOffset, long cb, int dwLockType)
    {
        throw new NotImplementedException();
    }




    // HResult IStream.Clone(out IStream ppstm)
    // {
    //     //ComStream newstream = new ComStream(_stream, false);
    //     //ppstm = newstream;
    //     ppstm = null;
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.Commit(int grfCommitFlags)
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.LockRegion(long libOffset, long cb, int dwLockType)
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.Read(byte[] pv, int cb, IntPtr pcbRead)
    // {
    //     if (!CanRead)
    //         throw new InvalidOperationException("Stream not readable");

    //     int read = Read(pv, 0, cb);
    //     if (pcbRead != IntPtr.Zero)
    //         Marshal.WriteInt64(pcbRead, read);
    //     return HResult.S_OK;
    // }

    // HResult IStream.Revert()
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
    // {
    //     SeekOrigin origin = (SeekOrigin)dwOrigin; //hope that the SeekOrigin enumeration won't change
    //     long pos = Seek(dlibMove, origin);
    //     if (plibNewPosition != IntPtr.Zero)
    //         Marshal.WriteInt64(plibNewPosition, pos);
    //     return HResult.S_OK;
    // }

    // HResult IStream.SetSize(long libNewSize)
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.Stat(out comtypes.STATSTG pstatstg, int grfStatFlag)
    // {
    //     pstatstg = new comtypes.STATSTG();
    //     pstatstg.cbSize = Length;
    //     return HResult.S_OK;
    // }

    // HResult IStream.UnlockRegion(long libOffset, long cb, int dwLockType)
    // {
    //     return HResult.E_NOTIMPL;
    // }

    // HResult IStream.Write(byte[] pv, int cb, IntPtr pcbWritten)
    // {
    //     if (!CanWrite)
    //         throw new InvalidOperationException("Stream is not writeable.");

    //     Write(pv, 0, cb);
    //     if (pcbWritten != null)
    //         Marshal.WriteInt32(pcbWritten, cb);
    //     return HResult.S_OK;
    // }
}