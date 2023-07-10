namespace SlippiSharp.Parser;

public class SlippiParser
{
    public static void Parse(string filePath)
    {
        var fileData = File.ReadAllBytes(filePath);
        var reader = new SpanReader(fileData.AsSpan());
    }
}