using System.Text.Json;
using LogInApp.Models;

namespace LogInApp.Services;

public class Service : IService
{
    private readonly string postsFile = "posts.json";
     private IList<Post> posts { get;  set; }

   public Service(){
       posts = File.Exists(postsFile) ? ReadData<Post>(postsFile) : new List<Post>();
    }

   private IList<T> ReadData<T>(string s)
   {
       using (var jsonReader = File.OpenText(s)) {
           return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
       }   }

   public async Task<IList<Post>> GetAllPostAsync()
   {
       List<Post> tmp=new List<Post>(posts);
       return tmp;
   }
   public async Task AddPostAsync(Post post)
    {
        posts.Add(post);
            }
}