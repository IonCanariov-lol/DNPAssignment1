using LogInApp.Models;

namespace LogInApp.Persistence;

public interface IFileContext
{
    void AddPost(Post post);
    List<Post> GetPostList();
}