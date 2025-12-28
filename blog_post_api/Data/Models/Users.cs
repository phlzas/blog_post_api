using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace blog_post_api.Data.Models
{
    public class Users : IdentityUser
    {
        public string? Name { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Blogs> blogs { get; set; } = new List<Blogs>();
        public List<Comments> comments { get; set; } =  new List<Comments>();
    }
}
