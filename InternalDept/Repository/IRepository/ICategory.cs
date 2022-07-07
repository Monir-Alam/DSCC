using InterDept.Models;

namespace InterDept.Repository.IRepository
{
    public interface ICategory : IRepository<Category>
    {
        void Update(Category obj);




    }
}
