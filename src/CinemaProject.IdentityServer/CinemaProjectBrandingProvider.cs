using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CinemaProject;

[Dependency(ReplaceServices = true)]
public class CinemaProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CinemaProject";
}
