namespace SlippiSharp.Parser.Enums;

public enum Cancel
{
    L = 1, // L-cancel
    Auto = 2, // Autocancel
    Teeter = 3, // Teeter cancel
    Edge = 4, // Edge / ledge cancel
    Jump = 5, // Jump cancel (for grabs / smashes)
    Dj = 6, // Double jump cancel
    Float = 7, // Float cancel
}