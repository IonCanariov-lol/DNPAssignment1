using LogInApp.Models;

namespace LogInApp.Services;

public interface IService
{
    Task<IList<Post>> GetAllPostAsync();
    Task AddPostAsync(Post post);

}