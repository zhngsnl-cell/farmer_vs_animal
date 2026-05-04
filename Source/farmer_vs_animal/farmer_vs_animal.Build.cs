// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class farmer_vs_animal : ModuleRules
{
	public farmer_vs_animal(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"farmer_vs_animal",
			"farmer_vs_animal/Variant_Platforming",
			"farmer_vs_animal/Variant_Platforming/Animation",
			"farmer_vs_animal/Variant_Combat",
			"farmer_vs_animal/Variant_Combat/AI",
			"farmer_vs_animal/Variant_Combat/Animation",
			"farmer_vs_animal/Variant_Combat/Gameplay",
			"farmer_vs_animal/Variant_Combat/Interfaces",
			"farmer_vs_animal/Variant_Combat/UI",
			"farmer_vs_animal/Variant_SideScrolling",
			"farmer_vs_animal/Variant_SideScrolling/AI",
			"farmer_vs_animal/Variant_SideScrolling/Gameplay",
			"farmer_vs_animal/Variant_SideScrolling/Interfaces",
			"farmer_vs_animal/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
