using SlippiSharp.Parser.Core;
using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record GameEnd(
    GameEndMethod GameEndMethod,
    sbyte LrasIndex,
    PortResource<sbyte> PlayerPlacements
);