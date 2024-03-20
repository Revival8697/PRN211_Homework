using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class RepoBase<T> where T : class
    {
        ConvenienceStoreContext ConvenienceStorecontext;
        DbSet<T> Dbset;   

        public RepoBase()
        {
             ConvenienceStorecontext = new ConvenienceStoreContext();
             Dbset = ConvenienceStorecontext.Set<T>();
            
        }
        
        public List<T> GetAll()
        {
            return Dbset.ToList();
        }
        
        public void Create(T entity)
        {
            Dbset.Add(entity);
            ConvenienceStorecontext.SaveChanges();
        }

        public bool Delete(T entity)
        {
            Dbset.Remove(entity);
            ConvenienceStorecontext.SaveChanges();
            return true;
        }
        public void Update(T entity)
        {
            var tracker = ConvenienceStorecontext.Attach(entity);
            tracker.State = EntityState.Modified;
            ConvenienceStorecontext.SaveChanges();

        }




    }
}
