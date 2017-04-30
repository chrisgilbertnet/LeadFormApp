using LeadFormApp.Domain.Entities;
using LeadFormApp.Infrastructure.Interfaces;
using LeadFormApp.Infrastructure.Repositories;
using Ninject.Modules;

namespace LeadFormApp.Services
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Contact>>().To<Repository<Contact>>();
        }
    }
}