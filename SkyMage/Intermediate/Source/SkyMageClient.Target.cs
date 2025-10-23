using UnrealBuildTool;

public class SkyMageClientTarget : TargetRules
{
	public SkyMageClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SkyMage");
	}
}
