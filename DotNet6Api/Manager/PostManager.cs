using DotNet6Api.Context;
using DotNet6Api.Interfaces.Manager;
using DotNet6Api.Models;
using DotNet6Api.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace DotNet6Api.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
        }

        public ICollection<Post> GetAll(string title)
        {
            return Get(c=>c.Title.ToLower()==title.ToLower());
        }

        public Post GetById(int id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }

        public ICollection<Post> GetPosts(int page, int pageSize)
        {
            if (page <= 1)
            {
                page = 0;
            }
            int totalNumber=page*pageSize;
            return GetAll().Skip(totalNumber).Take(pageSize).ToList();
        }

        public ICollection<Post> SearchPost(string text)
        {
            text= text.ToLower();
           return Get(c=>c.Title.ToLower().Contains(text)||c.Description.ToLower().Contains(text));
        }
    }
}
