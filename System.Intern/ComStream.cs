namespace System.Intern;





public class ComStream : InfraObject, IStream
{
    public Stream Stream { get; set; }



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



    public void Stat(out STATSTG pstatstg, int grfStatFlag)
    {
        pstatstg = new STATSTG();
        pstatstg.cbSize = this.Stream.Length;
    }




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
}