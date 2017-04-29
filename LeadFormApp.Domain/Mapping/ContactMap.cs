using LeadFormApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadFormApp.Domain.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            //key  
            HasKey(t => t.Id);

            //property  
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.FirstName);
            Property(t => t.LastName);
            Property(t => t.Address);
            Property(t => t.Address2);
            Property(t => t.City);
            Property(t => t.State);
            Property(t => t.Zip);
            Property(t => t.Email);

            //table  
            ToTable("Contacts");
        }
    }
}