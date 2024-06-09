using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("22AA7EE1-3B01-40F3-BF28-D6DB0B7636DB"),
                RoleId = Guid.Parse("14B1D4D7-F625-4E23-A804-80471120FCCD")

            },
            new AppUserRole
            {
                UserId = Guid.Parse("F1949DC5-7D0F-44B0-8A75-4C36A5218B9B"),
                RoleId = Guid.Parse("2BF79887-D581-4DEE-8029-3FD0C3702EC8")
            });
        }
    }
}
