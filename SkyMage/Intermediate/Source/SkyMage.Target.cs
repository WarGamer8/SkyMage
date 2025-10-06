using UnrealBuildTool;

public class SkyMageTarget : TargetRules
{
	public SkyMageTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SkyMage");
	}
}
