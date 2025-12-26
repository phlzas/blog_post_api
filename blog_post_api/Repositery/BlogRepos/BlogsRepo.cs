using blog_post_api.Data;
using blog_post_api.Data.Models;
using blog_post_api.Repositery.BlogsController;
using blog_post_api.Repositery.Genric;

namespace blog_post_api.Repositery.BlogsRepos
{
    public class BlogsRepo : GenricRepo<Blogs>, IBlogsRepo
    {
        public BlogsRepo(AppDbContext Context) : base(Context){ }


    }
}
