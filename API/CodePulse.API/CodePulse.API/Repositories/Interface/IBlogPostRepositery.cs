using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface IBlogPostRepositery
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);
    }
}
