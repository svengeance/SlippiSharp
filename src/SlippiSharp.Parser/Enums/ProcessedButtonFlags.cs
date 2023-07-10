namespace SlippiSharp.Parser.Enums;

public enum ProcessedButtonFlags
{
    JoystickUp = 0x00010000,
    JoystickDown = 0x00020000,
    JoystickLeft = 0x00040000,
    JoystickRight = 0x00080000,
    CStickUp = 0x00100000,
    CStickDown = 0x00200000,
    CStickLeft = 0x00400000,
    CStickRight = 0x00800000,
    Unused5 = 0x01000000,
    Unused6 = 0x02000000,
    Unused7 = 0x04000000,
    Unused8 = 0x08000000,
    Unused9 = 0x10000000,
    Unused10 = 0x20000000,
    Unused11 = 0x40000000,
    AnyTrigger = unchecked((int)0x80000000)
}