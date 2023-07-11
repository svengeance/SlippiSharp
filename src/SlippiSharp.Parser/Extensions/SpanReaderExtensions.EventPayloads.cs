using SlippiSharp.Parser.Core;
using SlippiSharp.Parser.Enums;
using SlippiSharp.Parser.SlippiObjects;

namespace SlippiSharp.Parser.Extensions;

public static partial class SpanReaderExtensions
{
    /// <summary>
    /// Parses the <a href="https://github.com/project-slippi/slippi-wiki/blob/master/SPEC.md#event-payloads">event payloads.</a>
    /// Each contains an <see cref="Event"/> and the corresponding size in bytes of each event in future frames.
    /// </summary>
    public static IEnumerable<EventPayload> ParseEventPayloads(this SpanReader reader)
    {
        var numberOfCommands = reader.ReadByte() - 1;

        for (var i = 0; i <= numberOfCommands; i += 3)
            yield return new EventPayload(
                Event: (Event)reader.ReadByte(),
                Size: reader.ReadInt16()
            );
    }
}