using LogInApp.Models;

namespace LogInApp.Services.Impls;

public class InMemoryUserService: IUserService
{
    public async Task<User?> GetUserAsync(string username)
    {
        User? find = users.Find(user => user.Name.Equals(username));
        return find;
    }

    private List<User> users = new()
    {
        new User("Troels", "Troels1234", "Teacher", 3, 1986),
        new User("Maria", "oneTwo3FOUR", "Student", 2, 2001),
        new User("Anne", "password", "HeadOfDepartment", 5, 1975),  
        new User("Ion","password","Student",2,2000 )
    };
}