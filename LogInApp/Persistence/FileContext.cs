using System.Text.Json;

namespace LogInApp.Persistence;
using Models;
public class FileContext : IFileContext
{
    public IList<Post> Posts { get; set; }
    
    private readonly string postsFile = "posts.json";

    public FileContext()
    {
        Posts = File.Exists(postsFile) ? ReadData<Post>(postsFile) : new List<Post>();
    }

    private IList<T> ReadData<T>(string s)
    {
        using (var jsonReader = File.OpenText(s)) {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            
        }
    }
    public void SavePostToFile()
    {
        // storing posts
        string jsonPost = JsonSerializer.Serialize(Posts, new JsonSerializerOptions {
            WriteIndented = true
        });
        using (StreamWriter outputFile = new StreamWriter(postsFile, false)) {
            outputFile.Write(jsonPost);
        }
    }

    public void AddPost(Post post)
    {
        Posts.Add(post);
        SavePostToFile();
    }

    public List<Post> GetPostList()
    {
        return (List<Post>) Posts;
    }
}