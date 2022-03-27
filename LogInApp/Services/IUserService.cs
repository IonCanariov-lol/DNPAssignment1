using LogInApp.Models;

namespace LogInApp.Services;

public interface IUserService

    {
        public Task<User> GetUserAsync(string username);
    }
//later add new methods like: adding, removing, getting all users, updating a user, etc.