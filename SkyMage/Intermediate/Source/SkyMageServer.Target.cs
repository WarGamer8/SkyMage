using UnrealBuildTool;

public class SkyMageServerTarget : TargetRules
{
	public SkyMageServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SkyMage");
	}
}
