# CLAUDE.md

This file provides guidance to Claude Code when working with code in this repository.

Read About/About.xml to get a description of the mod.

Anomaly DLC lore reference (plain language, no technical data): `Docs/Lore/` — start with `00_Anomaly_Lore.md` (six groups: 01 Flesh, 02 Cult, 03 Death, 04 Darkness & the Unseen, 05 Dark Archotech, 06 Abominations). New or enhanced anomalies should stay consistent with it.

DO NOT GUESS, ASK IF UNSURE

## Project Overview

**Stronger Anomaly** is a RimWorld 1.6 mod by kahirdragoon.
Package ID: `kahirdragoon.strongeranomaly`
Def prefix: `SA_`

## Build & Development

**Build**: `dotnet build` from `Source/StrongerAnomaly/`
**Output DLL**: `1.6/Assemblies/StrongerAnomaly.dll`

There are no automated tests — verification is done by loading the mod in-game.
Register debug actions in a `DebugActions_SA.cs` file; they appear in the dev mode menu.

Always check if something can be done with vanilla mechanics before writing custom C# code. Prefer XML-only solutions when possible.

Performance is important. Cache when it makes sense. Be very careful with everything that executes per tick.

BUILD the DLL at the end of every task to verify there are no compile errors.

## Source Lookup Paths

- RimWorld decompiled source: `d:\Rimworld Modding\Rimworld Source`
- Steam workshop mods: `e:\SteamLibrary\steamapps\workshop\content\294100\`

## XML Conventions

- All mod-specific def names use the `SA_` prefix (e.g. `SA_MyThing`).
- Patches go in `Patches/`; use `<mods>` guards for optional mod compatibility.
- Conditional content goes in `Mods/<ModName>/` folders loaded via `LoadFolders.xml`.

## C# Conventions

- Use C# latest features (`LangVersion latest` is set in the .csproj).
- Target framework is `net481` (Mono/.NET 4.8) — .NET 5+ runtime APIs are unavailable.
- Static def references go in `DefOf.cs` using the `[DefOf]` attribute.
