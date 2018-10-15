using MenuShell.Domain;

namespace MenuShell.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
