using SlippiSharp.Parser.Enums;

namespace SlippiSharp.Parser.SlippiObjects;

public record PreFrameUpdate(
    int FrameNumber,
    byte PlayerIndex,
    bool IsFollower,
    uint RandomSeed,
    ActionState ActionState,
    float XPosition,
    float YPosition,
    FacingDirection FacingDirection,
    float JoystickX,
    float JoystickY,
    float CStickX,
    float CStickY,
    float Trigger,
    ProcessedButtonFlags ProcessedButtonFlags,
    PhysicalButtonFlags ProcessPhysicalButtonFlags,
    PhysicalButtonFlags PhysicalButtons,    
    float LTrigger,
    float RTrigger,
    sbyte XAnalog,
    float DamagePercent
);