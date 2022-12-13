using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Globomantics.IdentityServer.Identity
{
    public class CustomPasswordValidator : IPasswordValidator<CustomUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<CustomUser> manager, CustomUser user, string password)
        {
            if (password.ToLowerInvariant().Contains("glob"))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "GlobomanticsVariant",
                    Description = "Variants of Globomantics cannot be used in a password."
                }));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}