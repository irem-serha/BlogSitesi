using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class AppUser :IdentityUser<Guid>,IEntityBase
    { 
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("f73f928c-3cb0-487e-933d-1d6472e25aee");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
