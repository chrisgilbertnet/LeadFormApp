using LeadFormApp.Domain.Entities;
using LeadFormApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadFormApp.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            this._contactRepository = contactRepository;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contactRepository.GetAllNoTracking;
        }

        public Contact Find(int id)
        {
            return _contactRepository.GetById(id);
        }

        public void Insert(Contact contact)
        {
            _contactRepository.Insert(contact);
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }
    }
}