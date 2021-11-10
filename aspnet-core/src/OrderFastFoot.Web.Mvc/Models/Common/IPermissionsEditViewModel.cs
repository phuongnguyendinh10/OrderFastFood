using System.Collections.Generic;
using OrderFastFoot.Roles.Dto;

namespace OrderFastFoot.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}