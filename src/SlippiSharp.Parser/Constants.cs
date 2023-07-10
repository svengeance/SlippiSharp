namespace SlippiSharp.Parser;

public static class Constants
{
    //Frame count starts at -123, so there are 123 startup frames
    public const int LoadFrame = -123;

    //First playable frame is -39, according to Fizzi's parser
    public const int PlayableFrame = -39;

    // FirstActionableFrameOfTheMatch (0Indexed, AssumingFrame0 == internal frame -123)
    public const int FirstFrame = PlayableFrame - LoadFrame;
}