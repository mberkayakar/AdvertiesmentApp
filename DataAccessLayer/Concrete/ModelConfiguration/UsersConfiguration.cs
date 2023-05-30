using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ModelConfiguration
{
    internal class UsersConfiguration : EntityTypeBuilder<Users>
    {
        public UsersConfiguration(IMutableEntityType entityType) : base(entityType)
        {
            
        }
    }
}
