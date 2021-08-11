using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySite.Domain.Repositories.Abstract;

namespace CompanySite.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepositroy ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepositroy serviceItemsRepositroy)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepositroy;
        }
        
    }
}
