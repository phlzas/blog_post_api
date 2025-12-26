using blog_post_api.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blog_post_api.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        DbSet<Blogs> Blogs { get; set; }
        DbSet<Comments> Comments { get; set; }
        DbSet<CommentReaction> commentReactions { get; set; }
        DbSet<BlogReaction> blogReactions { get; set; }
    }
}
