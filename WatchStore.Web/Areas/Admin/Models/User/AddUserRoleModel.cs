using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;
using WatchStore.Web.Areas.Identity.Data;

namespace WatchStore.Web.Areas.Admin.Models.User
{
    public class AddUserRoleModel
    {
        public AppUser user { get; set; }

        [DisplayName("Các role gán cho user")]
        public string[] RoleNames { get; set; }

        public List<IdentityRoleClaim<string>> claimsInRole { get; set; }
        public List<IdentityUserClaim<string>> claimsInUserClaim { get; set; }
    }
}
