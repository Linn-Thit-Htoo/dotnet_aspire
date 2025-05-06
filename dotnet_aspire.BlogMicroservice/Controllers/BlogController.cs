using dotnet_aspire.BlogMicroservice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_aspire.BlogMicroservice.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet("GetBlogs")]
        public IActionResult GetBlogs()
        {
            return Ok(new List<BlogModel>()
            {
                new BlogModel
                {
                    BlogId = 1,
                    BlogTitle = "Blog Title 1",
                    BlogAuthor = "Blog Author 1",
                    BlogContent = "Blog Content 1",
                    IsDeleted = false
                },
                new BlogModel
                {
                    BlogId = 2,
                    BlogTitle = "Blog Title 2",
                    BlogAuthor = "Blog Author 2",
                    BlogContent = "Blog Content 2",
                    IsDeleted = false
                },
                new BlogModel
                {
                    BlogId = 3,
                    BlogTitle = "Blog Title 3",
                    BlogAuthor = "Blog Author 3",
                    BlogContent = "Blog Content 3",
                    IsDeleted = false
                },
                new BlogModel
                {
                    BlogId = 4,
                    BlogTitle = "Blog Title 4",
                    BlogAuthor = "Blog Author 4",
                    BlogContent = "Blog Content 4",
                    IsDeleted = false
                },
            });
        }
    }
}
