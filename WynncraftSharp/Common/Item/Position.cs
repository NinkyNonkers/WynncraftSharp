namespace WynncraftSharp.Common.Item;

public class Position
{
    public int Left { get; internal set; }
    public int Right { get; internal set; }
    public int Above { get; internal set; }
    public int Under { get; internal set; }
    public int Touching { get; internal set; }
    public int NotTouching { get; internal set; }
}