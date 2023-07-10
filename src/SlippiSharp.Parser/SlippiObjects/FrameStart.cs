namespace SlippiSharp.Parser.SlippiObjects;

public record FrameStart(
    int FrameNumber,
    uint RandomSeed,
    uint FrameNumberIncludingPauses
);