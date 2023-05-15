using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace WatchStore.Web.Areas.Identity.Models.Manage
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }
    }
}
