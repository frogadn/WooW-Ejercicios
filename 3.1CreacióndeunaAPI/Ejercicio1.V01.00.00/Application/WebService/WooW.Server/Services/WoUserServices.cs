using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

namespace WooW.ServiceInterface
{
    public class WoUserServiceInterface : Service
    {
        public WoODataResponse<WoUser> Get(WoUserList ODataRequest)
        {
            string Fields =
                "Email,UserName,FirstName,LastName,DisplayName,PhoneNumber,BirthDate,Address,Address2,PostalCode,City,State,Country,Culture,Gender,Language,TimeZone".ToLower();

            var woTarget = new WoTargetConnection(Request, Db);

            if (ODataRequest.select.IsNullOrStringEmpty())
                ODataRequest.select = Fields;
            else
            {
                List<string> listFields = new List<string>(Fields.Split(','));
                List<string> listSelect = new List<string>(
                    ODataRequest.select.ToLower().Split(',')
                );

                foreach (var item in listSelect)
                {
                    if (!listFields.Contains(item))
                        throw new Exception($"Field {item} no existe");
                }
            }

            var oDataResult = WoGenericService.ODataGet<AppUser>(woTarget, ODataRequest, true);

            var oDataWoUser = new WoODataResponse<WoUser>
            {
                TotalizerValue = oDataResult.TotalizerValue,
                NextLink = oDataResult.NextLink,
                Context = oDataResult.Context,
                Count = oDataResult.Count,
                Value = new List<WoUser>()
            };

            foreach (var item in oDataResult.Value)
            {
                var woUser = new WoUser
                {
                    Email = item.Email,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DisplayName = item.DisplayName,
                    PhoneNumber = item.PhoneNumber,
                    BirthDate = item.BirthDate,
                    Address = item.Address,
                    Address2 = item.Address2,
                    PostalCode = item.PostalCode,
                    City = item.City,
                    State = item.State,
                    Country = item.Country,
                    Culture = item.Culture,
                };

                oDataWoUser.Value.Add(woUser);
            }

            return oDataWoUser;
        }

        public string Post(WoUser woUser)
        {
            var authRepo = HostContext.Resolve<IAuthRepository>();

            var user = authRepo.GetUserAuthByUserName(woUser.Email);

            if (user == null)
            {
                var newUser = new AppUser
                {
                    Email = woUser.Email,
                    UserName = woUser.UserName,
                    FirstName = woUser.FirstName,
                    LastName = woUser.LastName,
                    DisplayName = woUser.DisplayName,
                    PhoneNumber = woUser.PhoneNumber,
                    BirthDate = woUser.BirthDate,
                    Address = woUser.Address,
                    Address2 = woUser.Address2,
                    PostalCode = woUser.PostalCode,
                    City = woUser.City,
                    State = woUser.State,
                    Country = woUser.Country,
                    Culture = woUser.Culture,
                    Gender = woUser.Gender,
                    Language = woUser.Language,
                    TimeZone = woUser.TimeZone,
                    Roles = null,
                    Permissions = null,
                };

                user = authRepo.CreateUserAuth(newUser, woUser.__Password);
                authRepo.AssignRoles(user, woUser.Roles, woUser.Permissions);

                return $"User {newUser.UserName} added";
            }
            else
            {
                var newUser = new AppUser
                {
                    Email = woUser.Email,
                    UserName = woUser.UserName,
                    FirstName = woUser.FirstName,
                    LastName = woUser.LastName,
                    DisplayName = woUser.DisplayName,
                    PhoneNumber = woUser.PhoneNumber,
                    BirthDate = woUser.BirthDate,
                    Address = woUser.Address,
                    Address2 = woUser.Address2,
                    PostalCode = woUser.PostalCode,
                    City = woUser.City,
                    State = woUser.State,
                    Country = woUser.Country,
                    Culture = woUser.Culture,
                    Gender = woUser.Gender,
                    Language = woUser.Language,
                    TimeZone = woUser.TimeZone,
                    Roles = null,
                    Permissions = null
                };

                user = authRepo.UpdateUserAuth(user, newUser);
                if (woUser.__Password.IsNullOrStringEmpty())
                    user = authRepo.UpdateUserAuth(user, newUser);
                else
                    user = authRepo.UpdateUserAuth(user, newUser, woUser.__Password);

                var locRoles = authRepo.GetRoles(user);
                var locPermissions = authRepo.GetRoles(user);

                authRepo.UnAssignRoles(user, locRoles, locPermissions);
                authRepo.AssignRoles(user, woUser.Roles, woUser.Permissions);

                return $"User {newUser.UserName} updated";
            }
        }
    }
}
