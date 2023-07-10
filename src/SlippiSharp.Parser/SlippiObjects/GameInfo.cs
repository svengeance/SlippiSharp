using SlippiSharp.Parser.Core;
using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record GameInfo(
    byte GameBitfield1,
    byte GameBitfield2,
    byte GameBitfield3,
    byte GameBitfield4,
    bool IsRainingBombs,
    bool IsTeamGame,
    ItemSpawnBehavior ItemSpawnBehavior,
    sbyte SelfDestructScoreValue,
    ushort StageId,
    uint SecondsInGame,
    byte ItemSpawnBitfield1,
    byte ItemSpawnBitfield2,
    byte ItemSpawnBitfield3,
    byte ItemSpawnBitfield4,
    byte ItemSpawnBitfield5,
    float DamageRatio,
    PortResource<byte> CharacterIds,
    PortResource<PlayerType> PlayerTypes,
    PortResource<byte> StockCounts,
    PortResource<byte> CostumeIndex,
    PortResource<TeamShade> TeamShades,
    PortResource<byte> Handicaps,
    PortResource<TeamColor> TeamColors,
    PortResource<byte> PlayerBitfields,
    PortResource<byte> CpuLevels,
    PortResource<ushort> DamageStart,
    PortResource<ushort> DamageSpawn,
    PortResource<float> OffenseRatio,
    PortResource<float> DefenseRatio,
    PortResource<float> ModelScale
);