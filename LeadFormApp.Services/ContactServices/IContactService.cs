using LeadFormApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadFormApp.Services.ContactServices
{
    public interface IContactService
    {
        IEnumerable<Contact> GetContacts();

        Contact Find(int id);

        void Insert(Contact model);

        void Delete(int id);
    }
}