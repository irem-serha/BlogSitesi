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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                ViewCount = 15,
                CategoryId = Guid.Parse("7CB57EBD-A4A2-4DE9-B3AE-1FB226DDA0C8"),
                ImageId = Guid.Parse("3F7C23E8-8329-4677-91D2-C557B83ECC68"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("22AA7EE1-3B01-40F3-BF28-D6DB0B7636DB")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Core Deneme Makalesi 1",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                ViewCount = 15,
                CategoryId = Guid.Parse("C8711160-E666-4106-9D63-4F04B886B52A"),
                ImageId = Guid.Parse("3873785E-2E56-4747-B5BA-0AB6E7CFF833"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("F1949DC5-7D0F-44B0-8A75-4C36A5218B9B")
            }
            );
        }
    }
}
