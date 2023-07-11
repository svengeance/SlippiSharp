using SlippiSharp.Parser.Core;
using SlippiSharp.Parser.SlippiObjects;

namespace SlippiSharp.Parser.Extensions;

public static partial class SpanReaderExtensions
{
    private static readonly int ReaderPrefixLength = "{U\x03raw[$U#l".Length; 
    
    /// <summary>
    /// Parses the <a href="https://github.com/project-slippi/slippi-wiki/blob/master/SPEC.md#the-raw-element">raw element.</a>
    /// It contains the number of frames that are available for parsing, but will be 0 in a live game.
    /// </summary>
    public static Header ParseHeader(this SpanReader reader)
    {
        reader.Offset += ReaderPrefixLength;

        return new Header(
            NumberOfEvents: reader.ReadInt32()
        );
    }
}