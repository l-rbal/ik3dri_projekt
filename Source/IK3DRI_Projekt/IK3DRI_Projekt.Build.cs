// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class IK3DRI_Projekt : ModuleRules
{
	public IK3DRI_Projekt(ReadOnlyTargetRules Target) : base(Target)
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
			"IK3DRI_Projekt",
			"IK3DRI_Projekt/Variant_Horror",
			"IK3DRI_Projekt/Variant_Horror/UI",
			"IK3DRI_Projekt/Variant_Shooter",
			"IK3DRI_Projekt/Variant_Shooter/AI",
			"IK3DRI_Projekt/Variant_Shooter/UI",
			"IK3DRI_Projekt/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
