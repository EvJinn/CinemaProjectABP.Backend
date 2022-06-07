using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CinemaProject;

[Dependency(ReplaceServices = true)]
public class CinemaProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CinemaProject";
}
