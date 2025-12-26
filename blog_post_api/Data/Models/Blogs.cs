namespace blog_post_api.Data.Models
{
    public class Blogs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UserName { get; set; } = string.Empty;
        public string UserId { get; set; }
        public Users Users { get; set; } 
        public List<Comments> Comments { get; set; } = new List<Comments>();
        public ICollection<BlogReaction> Reactions { get; set; }
    }
}