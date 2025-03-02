using EBookStore.Models.Domain;
using EBookStore.Repositories.Abstract;

namespace EBookStore.Repositories.Implementation
{

    public class GenerService : IGenerService
    {
        
        private readonly DataBaseContext context;
        public GenerService(DataBaseContext context)
        {
            this.context = context;
        }
        public bool Add(Gener model)
        {
            try
            {
                context.Gener.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Gener.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Gener FindById(int id)
        {
            return context.Gener.Find(id);
        }

        public IEnumerable<Gener> GetAll()
        {
            return context.Gener.ToList();
        }

        public bool Update(Gener model)
        {
            try
            {
                context.Gener.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

