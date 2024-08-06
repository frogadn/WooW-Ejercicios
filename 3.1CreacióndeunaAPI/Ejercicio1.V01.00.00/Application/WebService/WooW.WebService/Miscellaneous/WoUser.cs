using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.Configuration;
using WooW.Core;

namespace WooW.Model
{
    public static class PermisionNames
    {
        public const string UserAdd = nameof(UserAdd);
    }

#if SERVER
    [RequiredRole(RoleNames.Admin)]
    [RequiredPermission(PermisionNames.UserAdd)]
    [AutoApply(Behavior.AuditQuery)]
#endif
    [Tag("WoIntrinsic")]
    [Route("/api/WoUser", "POST")]
    [JsonObject(MemberSerialization.OptOut)]
    public class WoUser
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Culture { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Permissions { get; set; }
        public string __Password { get; set; }
    };

#if SERVER
    [RequiredRole(RoleNames.Admin)]
    [RequiredPermission(PermisionNames.UserAdd)]
    [AutoApply(Behavior.AuditQuery)]
#endif
    [Tag("WoIntrinsic")]
    [Route("/api/WoUserList", "GET")]
    [JsonObject(MemberSerialization.OptOut)]
    public class WoUserList : IWoODataRequest
    {
        public string select { get; set; }
        public string filter { get; set; }
        public string orderby { get; set; }
        public bool count { get; set; }
        public int? top { get; set; }
        public int? skip { get; set; }
        public bool withref { get; set; }
        public string totalizer { get; set; }
    }
}
