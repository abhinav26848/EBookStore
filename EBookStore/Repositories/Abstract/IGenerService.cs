using EBookStore.Models.Domain;

namespace EBookStore.Repositories.Abstract
{
    public interface IGenerService
    {
        bool Add(Gener model);
        bool Update(Gener model);
        bool Delete(int id);
        Gener FindById(int id);
        IEnumerable<Gener> GetAll();

    }
}
