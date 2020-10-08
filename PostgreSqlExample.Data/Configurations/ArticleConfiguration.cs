using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlExample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSqlExample.Data.Configurations
{
    /// <summary>
    /// Article tablosunun özelliklerini tanımlayacağımız bölüm.
    /// </summary>
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(300);
            builder.Property(s => s.Description).HasMaxLength(600);
        }
    }
}