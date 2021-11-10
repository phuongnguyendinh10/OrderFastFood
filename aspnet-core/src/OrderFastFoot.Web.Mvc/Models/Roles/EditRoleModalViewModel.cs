using Abp.AutoMapper;
using OrderFastFoot.Roles.Dto;
using OrderFastFoot.Web.Models.Common;

namespace OrderFastFoot.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
