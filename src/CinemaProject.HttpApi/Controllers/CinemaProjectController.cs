using CinemaProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CinemaProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CinemaProjectController : AbpControllerBase
{
    protected CinemaProjectController()
    {
        LocalizationResource = typeof(CinemaProjectResource);
    }
}
