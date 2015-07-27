using CodedHomes.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodedHomes.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(p => p.Id).HasColumnOrder(0);

            this.Property(p => p.UserName).IsRequired().HasMaxLength(200);
            this.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            this.Property(p => p.LastName).IsRequired().HasMaxLength(100);
        }
    }
}
