using LeadFormApp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LeadFormApp.Domain.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            //key  
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //properties
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