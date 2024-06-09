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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7CB57EBD-A4A2-4DE9-B3AE-1FB226DDA0C8"),
                Name = "Asp.Net Core",
                CreatedBy = "AdminTest",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("C8711160-E666-4106-9D63-4F04B886B52A"),
                Name = "Visual Studio 2022",
                CreatedBy = "AdminTest",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
            
        }
    }
}
