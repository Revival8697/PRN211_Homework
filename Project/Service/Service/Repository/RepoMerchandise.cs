using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class RepoMerchandise : RepoBase<Merchandise>
    {
        ConvenienceStoreContext context = new ConvenienceStoreContext();

        public void Update(Merchandise entity)
        {
            var e = context.Merchandises.SingleOrDefault(m => m.MerId == entity.MerId);
            e.MerName = entity.MerName;
            e.MerPrice = entity.MerPrice;
            e.MerUnit = entity.MerUnit;
            e.MerQuantity = entity.MerQuantity;
            e.MerIdCategory = entity.MerIdCategory;

            context.SaveChanges();
        }
    }
}
