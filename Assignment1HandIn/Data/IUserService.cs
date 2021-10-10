using Models;

namespace Assignment1HandIn.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}