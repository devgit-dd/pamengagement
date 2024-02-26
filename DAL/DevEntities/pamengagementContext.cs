using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DevEntities;

public partial class pamengagementContext : DbContext
{
    public pamengagementContext()
    {
    }

    public pamengagementContext(DbContextOptions<pamengagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<demoTable> demoTables { get; set; }

    public virtual DbSet<tbldata_answer> tbldata_answers { get; set; }

    public virtual DbSet<tbldata_questiondetail> tbldata_questiondetails { get; set; }

    public virtual DbSet<tbldata_response> tbldata_responses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=dpg-cnbp5nf109ks73buk070-a.singapore-postgres.render.com;Database=pamengagement;Username=pg;Password=USCTxuUrCx9imwcwRCc6qwl95lkETrvZ;CommandTimeout=1000");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<demoTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("demoTable");
        });

        modelBuilder.Entity<tbldata_answer>(entity =>
        {
            entity.HasKey(e => e.id).HasName("tbldata_answers_pkey");

            entity.Property(e => e.answer).HasColumnType("character varying");
            entity.Property(e => e.text_for_question).HasColumnType("character varying");

            entity.HasOne(d => d.question).WithMany(p => p.tbldata_answers)
                .HasForeignKey(d => d.questionid)
                .HasConstraintName("tbldata_answers_questionid_fkey");
        });

        modelBuilder.Entity<tbldata_questiondetail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("tbldata_questiondetails_pkey");

            entity.Property(e => e.hinttext).HasColumnType("character varying");
            entity.Property(e => e.imagepath).HasColumnType("character varying");
            entity.Property(e => e.name).HasMaxLength(100);
        });

        modelBuilder.Entity<tbldata_response>(entity =>
        {
            entity.HasKey(e => e.id).HasName("tbldata_responses_pkey");

            entity.Property(e => e.teamname).HasColumnType("character varying");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
