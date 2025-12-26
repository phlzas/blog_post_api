using blog_post_api.Data;
using blog_post_api.Data.Models;
using blog_post_api.Repositery.BlogsController;
using blog_post_api.Repositery.Genric;

namespace blog_post_api.Repositery.BlogsRepos
{
    public class UserRepo: GenricRepo<Users>, IUserRepo
    {
        public UserRepo(AppDbContext Context) : base(Context) { }

    }


}
