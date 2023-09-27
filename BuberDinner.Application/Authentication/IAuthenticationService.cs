using BuberDinner.Application.Authentication.Common;
using ErrorOr;

namespace BuberDinner.Application.Authentication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    ErrorOr<AuthenticationResult> Login(string email, string password);
}