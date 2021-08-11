using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySite.Domain.Entities;

namespace CompanySite.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepositroy
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItem(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
