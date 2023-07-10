using System.Runtime.CompilerServices;

using static System.Buffers.Binary.BinaryPrimitives;

namespace SlippiSharp.Parser;

public ref struct SpanReader
{
    readonly ReadOnlySpan<byte> baseSpan;


    public int Offset { get; set; }

    public bool EndOfSpan => Offset >= baseSpan.Length;

    public ReadOnlySpan<byte> Slice => baseSpan[Offset..];

    public SpanReader(ReadOnlySpan<byte> span)
    {
        baseSpan   = span;
        Offset     = 0;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadInt16(out short result)
    {
        var success = TryReadInt16BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(short);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadInt32(out int result)
    {
        var success = TryReadInt32BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(int);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadInt64(out long result)
    {
        var success = TryReadInt64BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(long);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadUInt16(out ushort result)
    {
        var success = TryReadUInt16BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(ushort);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadUInt32(out uint result)
    {
        var success = TryReadUInt32BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(uint);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadUInt64(out ulong result)
    {
        var success = TryReadUInt64BigEndian(Slice, out result);

        if (success)
            Offset += sizeof(ulong);

        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadSingle(out float result)
    {
        var success = TryReadUInt32BigEndian(Slice, out var value);

        if (success)
            Offset += sizeof(uint);

        result = Unsafe.As<uint, float>(ref value);
        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryReadDouble(out double result)
    {
        var success = TryReadUInt64BigEndian(Slice, out var value);

        if (success)
            Offset += sizeof(ulong);

        result = Unsafe.As<ulong, double>(ref value);
        return success;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public short PeekInt16()
    {
        var success = TryReadInt16BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int PeekInt32()
    {
        var success = TryReadInt32BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public long PeekInt64()
    {
        var success = TryReadInt64BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ushort PeekUInt16()
    {
        var success = TryReadUInt16BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint PeekUInt32()
    {
        var success = TryReadUInt32BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong PeekUInt64()
    {
        var success = TryReadUInt64BigEndian(Slice, out var result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float PeekSingle()
    {
        var value = PeekUInt32();
        return Unsafe.As<uint, float>(ref value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double PeekDouble()
    {
        var value = PeekUInt64();
        return Unsafe.As<ulong, double>(ref value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public short ReadInt16()
    {
        var result = ReadInt16BigEndian(Slice);

        Offset += sizeof(short);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int ReadInt32()
    {
        var result = ReadInt32BigEndian(Slice);

        Offset += sizeof(int);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public long ReadInt64()
    {
        var result = ReadInt64BigEndian(Slice);

        Offset += sizeof(long);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ushort ReadUInt16()
    {
        var result = ReadUInt16BigEndian(Slice);

        Offset += sizeof(ushort);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint ReadUInt32()
    {
        var result = ReadUInt32BigEndian(Slice);

        Offset += sizeof(uint);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong ReadUInt64()
    {
        var result = ReadUInt64BigEndian(Slice);

        Offset += sizeof(ulong);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float ReadSingle()
    {
        var value = ReadUInt32();
        return Unsafe.As<uint, float>(ref value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double ReadDouble()
    {
        var value = ReadUInt64();
        return Unsafe.As<ulong, double>(ref value);
    }
}