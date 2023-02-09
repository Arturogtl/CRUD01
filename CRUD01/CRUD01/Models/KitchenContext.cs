using System;
using System.Collections.Generic;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD01.Models;

public partial class KitchenContext : DbContext
{
    public KitchenContext()
    {
    }

    public KitchenContext(DbContextOptions<KitchenContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Plate> Plates { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost; database=Kitchen; integrated security=true; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
