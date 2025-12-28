namespace blog_post_api.Data.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int ?ParentCommentId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string UserId { get; set; }
        public Users Users { get; set; }
        public int BlogsId { get; set; }
        public Blogs Blogs { get; set; }

        public ICollection<CommentReaction> Reactions { get; set; } = new HashSet<CommentReaction>();
    }
}
