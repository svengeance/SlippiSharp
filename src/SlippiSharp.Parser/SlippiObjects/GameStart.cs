using SlippiSharp.Parser.Core;
using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record GameStart(
    Version Version,
    GameInfo GameInfo,
    uint Seed,
    PortResource<DashbackFix> DashbackFixes,
    PortResource<ShieldDropFix> ShieldDropFixes,
    PortResource<string> NameTags,
    bool Pal,
    bool FrozenPokemonStadium,
    byte MinorScene,
    byte MajorScene,
    PortResource<string> DisplayNames,
    PortResource<string> ConnectCodes,
    PortResource<string> UserIds,
    LanguageOption LanguageOption,
    string MatchId,
    uint GameNumber,
    uint TieBreakerNumber
);