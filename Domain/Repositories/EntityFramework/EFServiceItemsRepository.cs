using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CompanySite.Domain.Entities;
using CompanySite.Domain.Repositories.Abstract;

namespace CompanySite.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepositroy
    {
        private readonly AppDbContext context;

        EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }


        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public ServiceItem GetServiceItem(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
