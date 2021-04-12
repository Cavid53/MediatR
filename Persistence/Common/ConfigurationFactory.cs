using Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Common
{
    public static class ConfigurationFactory
    {
        public static EntityTypeBuilder<TEntity> ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
               where TEntity : BaseEntity
        {
            builder.HasKey(e => e.Id);
            return builder;
        }
    }
}
