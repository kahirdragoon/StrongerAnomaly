using RimWorld;
using Verse;

namespace StrongerAnomaly;

/// <summary>Static def references resolved by the game at startup.</summary>
[DefOf]
public static class SADefOf
{
    // Example — uncomment and rename when you add defs:
    // public static ThingDef SA_MyThing;

    static SADefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(SADefOf));
}
