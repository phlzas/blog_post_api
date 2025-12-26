using blog_post_api.Data;
using blog_post_api.Data.Models;
using blog_post_api.Repositery.Genric;

namespace blog_post_api.Repositery.BlogReactionRepo
{
    public class BlogReactionsRepo : GenricRepo<BlogReaction>, IBlogReactionRepo
    {
        public BlogReactionsRepo(AppDbContext context) : base(context)
        {
        }

    }
}
