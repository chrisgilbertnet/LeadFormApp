using LeadFormApp.Domain.Entities;
using LeadFormApp.Domain.Interfaces;
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

        public void AddContact(Contact contact)
        {
            _contactRepository.Insert(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contactRepository.GetAllNoTracking;
        }

        public Contact Find(int id)
        {
            return _contactRepository.GetById(id);
        }

        public void Insert(Contact model)
        {
            _contactRepository.Insert(model);
        }
    }
}