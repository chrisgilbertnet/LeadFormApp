using LeadFormApp.Domain.Entities;
using LeadFormApp.Domain.Interfaces;
using LeadFormApp.Infrastructure.Repositories;
using Ninject.Modules;

namespace LeadFormApp.Services
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Blog>>().To<Repository<Blog>>();
        }
    }
}
