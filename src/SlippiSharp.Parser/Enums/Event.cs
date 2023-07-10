namespace SlippiSharp.Parser.Enums;

public enum Event {
    SplitMessage   = 0x10,
    EventPayloads = 0x35,
    GameStart  = 0x36,
    PreFrame   = 0x37,
    PostFrame  = 0x38,
    GameEnd    = 0x39,
    FrameStart = 0x3A,
    ItemUpdate = 0x3B,
    Bookend     = 0x3C,
    GeckoList  = 0x3D,
};