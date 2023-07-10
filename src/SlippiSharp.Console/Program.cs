// See https://aka.ms/new-console-template for more information

using System.Buffers.Binary;
using SlippiSharp.Parser.Enums;

var headerBytes = "{U\x03raw[$U#l"u8;

ReadOnlySpan<byte> data = File.ReadAllBytes("Game.slp").AsSpan();

// We skip the preamble leading up to the data array
data = data[headerBytes.Length..];

// Read the number of events
var numberOfEvents = ReadInt(ref data);

// Establish our (command, commandLength) pairs
var commandLengths = new Dictionary<Event, short>(10);
var commandByte = ReadByte(ref data);
var commandLengthBytes = ReadByte(ref data) - 1;

Console.WriteLine($"Preparing to read {commandLengthBytes / 3.0} commands..");

for (int i = 0; i < commandLengthBytes; i += 3)
{
    var command = ReadByte(ref data);
    var commandSize = ReadShort(ref data);

    Console.WriteLine($"{(Event)command} has {commandSize:N0} bytes.");
    
    commandLengths[(Event)command] = commandSize;
}

Console.WriteLine();

static byte ReadByte(ref ReadOnlySpan<byte> source)
{
    var @byte = source[0];
    source = source[1..];
    return @byte;
}

static short ReadShort(ref ReadOnlySpan<byte> source)
{
    var @short = BinaryPrimitives.ReadInt16BigEndian(source);
    source = source[2..];
    return @short;
}

static int ReadInt(ref ReadOnlySpan<byte> source)
{
    var @int = BinaryPrimitives.ReadInt32BigEndian(source);
    source = source[4..];
    return @int;
}

