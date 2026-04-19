using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleTask;
public unsafe class UString : IDisposable
{
    private char* _buffer;
    private readonly int _length;
    private bool _disposed = false;
    public int Length => _length;
    public UString(char* buffer, int length, bool disposed)
    {
        _buffer = buffer;
        _length = length;
        _disposed = disposed;
    }
    public UString(string s)
    {
        if(s == null) throw new ArgumentNullException("s");
        _length = s.Length;
        int sizeInBytes = _length * sizeof(int);
        _buffer = (char*)NativeMemory.Alloc((nuint)sizeInBytes);
        fixed(char* sourcePtr = s)
        {
            Buffer.MemoryCopy(sourcePtr, _buffer, sizeInBytes, sizeInBytes);
        }
        Console.WriteLine($"[LOG] Memory allocated. Adress: {(long)(_buffer)}");
    }
    ~UString()
    {
        Dispose(false);
    }
    public override string ToString()
    { 
        return new string (_buffer, 0, _length);
    }

    
    public char this[int index]
    {
        get
        { 
            if(index< 0 || index >= _length) throw new IndexOutOfRangeException();
            return _buffer[index]; 
        }

        set
        {
            if (index< 0 || index >= _length) throw new IndexOutOfRangeException();
            _buffer[index] = value;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (_buffer != null)
            {
                NativeMemory.Free( _buffer);
                Console.WriteLine($"[LOG] Allocated memory freed");
                _buffer = null;
            }
            _disposed = true;
        }
    }
}
