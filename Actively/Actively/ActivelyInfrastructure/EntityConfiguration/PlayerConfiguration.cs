﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ActivelyDomain.Entities;

namespace ActivelyInfrastructure.EntityConfiguration
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(x => x.NickName)
                .IsRequired()
                .HasMaxLength(25);

            builder.HasMany(x => x.Games)
                .WithMany(x => x.Players);
        }
    }
}
