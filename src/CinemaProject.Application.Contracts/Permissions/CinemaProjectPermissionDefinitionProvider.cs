using CinemaProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CinemaProject.Permissions;

public class CinemaProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CinemaProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CinemaProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CinemaProjectResource>(name);
    }
}
