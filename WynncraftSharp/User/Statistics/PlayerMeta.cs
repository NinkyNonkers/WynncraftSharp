﻿using WynncraftSharp.Store;

namespace WynncraftSharp.User.Statistics;

public class PlayerMeta
{
    public DateTime FirstJoin { get; internal set; }
    public DateTime LastJoin { get; internal set; }
    public PlayerLocation Location { get; internal set; }
    public Rank Tag { get; internal set; }
    public bool Veteran { get; internal set; }
}