using RimWorld;
using UnityEngine;
using Verse;

namespace StrongerAnomaly;

/// <summary>Mod entry point — handles settings registration.</summary>
public class StrongerAnomalyMod : Mod
{
    public static StrongerAnomalySettings Settings { get; private set; } = null!;

    public StrongerAnomalyMod(ModContentPack content) : base(content)
    {
        Settings = GetSettings<StrongerAnomalySettings>();
    }

    public override string SettingsCategory() => "Stronger Anomaly";

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing = new Listing_Standard();
        listing.Begin(inRect);
        // TODO: add settings controls here
        listing.End();
    }
}

public class StrongerAnomalySettings : ModSettings
{
    // TODO: add public fields for each setting

    public override void ExposeData()
    {
        base.ExposeData();
        // TODO: Scribe_Values.Look(...) for each field
    }
}
