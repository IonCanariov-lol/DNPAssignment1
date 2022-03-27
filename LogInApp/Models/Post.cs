using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LogInApp.Models;

public class Post
{
    [Required]
    [JsonPropertyName("postTitle")]
    public String PostTitle { get; set; }
  
    [Required]
    [JsonPropertyName("body")]
    public String Body
     { get; set; }
    
    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }
}