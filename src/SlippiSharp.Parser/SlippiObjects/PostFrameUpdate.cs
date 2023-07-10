using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record PostFrameUpdate(
    int FrameNumber,
    byte PlayerIndex,
    bool IsFollower,
    byte InternalCharacterId,
    ActionState ActionState,
    float XPosition,
    float YPosition,
    FacingDirection FacingDirection,
    float DamagePercent,
    float ShieldSize,
    Attack LastAttack,
    byte CurrentComboCount,
    byte LastHitBy,
    byte StocksRemaining,
    float ActionStateFrameCounter,
    byte StateBitFlags1,
    byte StateBitFlags2,
    byte StateBitFlags3,
    byte StateBitFlags4,
    byte StateBitFlags5,
    float HitStunRemaining,
    GroundState GroundState,
    ushort LastGroundId,
    byte JumpsRemaining,
    LCancelStatus LCancelStatus,
    float SelfInducedAirXSpeed,
    float SelfInducedYSpeed,
    float AttackBasedXSpeed,
    float AttackBasedYSpeed,
    float SelfInducedGroundXSpeed,
    float HitlagFramesRemaining,
    uint AnimationIndex
);