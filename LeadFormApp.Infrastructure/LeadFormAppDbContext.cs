using LeadFormApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadFormApp.Infrastructure
{
    public class LeadFormAppDbContext : DbContext
    {
        // Your context has been configured to use a 'LeadFormDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LeadForm.Data.LeadFormDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LeadFormDbContext' 
        // connection string in the application configuration file.
        public LeadFormAppDbContext()
            : base("name=LeadFormDbContext")
        {
            //disable initializer to not do migrations
            Database.SetInitializer<LeadFormAppDbContext>(null);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Contact> Contacts { get; set; }
    }
}
