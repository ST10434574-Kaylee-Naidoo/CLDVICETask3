using System;
using System.Collections.Generic;
using CLDVIceTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CLDVIceTask.Data;

public partial class IceTask3DbContext : DbContext
{
    public IceTask3DbContext()
    {
    }

    public IceTask3DbContext(DbContextOptions<IceTask3DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCACDB9D4027");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePicture)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
