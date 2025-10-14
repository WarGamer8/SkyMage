using UnrealBuildTool;

public class SkyMageEditorTarget : TargetRules
{
	public SkyMageEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SkyMage");
	}
}
