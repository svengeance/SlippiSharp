using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record ItemUpdate(
    int FrameNumber,
    Item Item,
    byte State,
    FacingDirection FacingDirection,
    float XVelocity,
    float YVelocity,
    float XPosition,
    float YPosition,
    ushort DamageTaken,
    float ExpirationTimer,
    uint SpawnId,
    byte SamusMissileType,
    byte PeachTurnipFace,
    bool IsLaunchedChargedShot,
    byte ChargedShotPower,
    sbyte ItemOwner
);