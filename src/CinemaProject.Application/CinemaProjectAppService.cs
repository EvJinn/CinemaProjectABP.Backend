using System;
using System.Collections.Generic;
using System.Text;
using CinemaProject.Localization;
using Volo.Abp.Application.Services;

namespace CinemaProject;

/* Inherit your application services from this class.
 */
public abstract class CinemaProjectAppService : ApplicationService
{
    protected CinemaProjectAppService()
    {
        LocalizationResource = typeof(CinemaProjectResource);
    }
}
