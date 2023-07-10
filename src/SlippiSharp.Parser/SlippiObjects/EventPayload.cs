using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record EventPayload(
    Event Event,
    short Size
);