using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using プロジェクト5.Models;

namespace プロジェクト5.Services
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDBContext context;
        private DbSet<T> entities;
        
        public SQLRepository(AppDBContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public int Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");

            entities.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }
    }
}
