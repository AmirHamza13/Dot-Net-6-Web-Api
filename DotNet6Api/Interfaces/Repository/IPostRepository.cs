using DotNet6Api.Models;
using EF.Core.Repository.Interface.Repository;

namespace DotNet6Api.Interfaces.Repository
{
    public interface IPostRepository:ICommonRepository<Post>
    {
    }
}
