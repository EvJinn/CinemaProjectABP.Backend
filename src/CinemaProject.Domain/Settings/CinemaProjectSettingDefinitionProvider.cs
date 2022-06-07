using Volo.Abp.Settings;

namespace CinemaProject.Settings;

public class CinemaProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CinemaProjectSettings.MySetting1));
    }
}
