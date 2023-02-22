using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1_feb20.Models;

public partial class SampledbContext : DbContext
{
    public SampledbContext()
    {
    }

    public SampledbContext(DbContextOptions<SampledbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tuser> Tusers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=IN3314428W1\\SQLEXPRESS;Initial Catalog=sampledb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tuser>(entity =>
        {
            entity.ToTable("Tuser");

            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).HasMaxLength(500);
            entity.Property(e => e.UserMessage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
