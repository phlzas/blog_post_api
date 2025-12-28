using blog_post_api.Data.Models;
using blog_post_api.Repositery.BlogReactionRepo;
using blog_post_api.Repositery.BlogsController;
using blog_post_api.Repositery.Genric;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace blog_post_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        protected readonly IBlogsRepo _blogRepo;
        protected readonly IBlogReactionRepo  _blogReactionRepo;
        protected readonly   IGenricRepo<Blogs> _genric;


        public BlogController (IBlogsRepo blogRepo, IGenricRepo<Blogs> genric, IBlogReactionRepo blogReactionRepo)
        {
            _blogRepo = blogRepo;
            _blogReactionRepo = blogReactionRepo;
            _genric = genric;
        }

        private object Project(Blogs b)
        {
            if (b == null) return null;
            return new
            {
                b.Id,
                b.Title,
                b.Description,
                b.CreatedAt,
                b.UserName,
                b.UserId,
                Author = b.Users == null ? null : new {
                    Id = b.Users.Id,
                    b.Users.UserName,
                    b.Users.Name,
                    b.Users.CreatedAt
                },
                Comments = b.Comments?.Select(c => new {
                    c.Id,
                    c.Description,
                    c.CreatedAt,
                    c.ParentCommentId,
                    c.IsDeleted,
                    c.UserId
                }),
                Reactions = b.Reactions?.Select(r => new {
                    r.Id,
                    Type = r.reactionType,
                    UserId = r.Users?.Id,
                    UserName = r.Users?.UserName
                })
            };
        }

        [HttpGet]
       public async Task<IActionResult> GetAll() {
            var items = await _genric.getAll();
            var projected = items.Select(Project);
            return Ok(projected);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _genric.getById(id);
            if (item == null) return NotFound();
            return Ok(Project(item));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Blogs blog)
        {
            if (blog == null) return BadRequest();
            var created = await _genric.add(blog);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, Project(created));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Blogs blog)
        {
            if (blog == null || blog.Id != id) return BadRequest();
            var existing = await _genric.getById(id);
            if (existing == null) return NotFound();
            var updated = await _genric.update(blog);
            return Ok(Project(updated));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _genric.getById(id);
            if (existing == null) return NotFound();
            var removed = await _genric.remove(id);
            return Ok(Project(removed));
        }
    }
}
