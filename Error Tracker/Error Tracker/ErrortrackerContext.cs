using System;
using System.Collections.Generic;
using System.DirectoryServices;
using Microsoft.EntityFrameworkCore;

namespace Error_Tracker;

public partial class ErrortrackerContext : DbContext
{
    public static string password;

    public ErrortrackerContext()
    {
        StreamReader streamReader = File.OpenText("password.txt");
        password = streamReader.ReadLine();
        
    }

    public ErrortrackerContext(DbContextOptions<ErrortrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Change> Changes { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Errorcomment> Errorcomments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Projectcomment> Projectcomments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql($"server=172.234.216.136;user=user1;password={password};database=errortracker", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.38-MariaDB"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PRIMARY");

            entity.ToTable("account");

            entity.HasIndex(e => e.Username, "username_UNIQUE").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(45)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Change>(entity =>
        {
            entity.HasKey(e => new { e.ChangeId, e.ProjectId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("change");

            entity.HasIndex(e => e.ProjectId, "change_FK");

            entity.Property(e => e.ChangeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("change_id");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Change1)
                .HasMaxLength(45)
                .HasColumnName("change");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Project).WithMany(p => p.Changes)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("change_FK");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PRIMARY");

            entity.ToTable("error");

            entity.HasIndex(e => e.ProjectId, "error_FK");

            entity.Property(e => e.ErrorId).HasColumnName("error_id");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Severity).HasColumnName("severity");
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(45)
                .HasColumnName("type");

            entity.HasOne(d => d.Project).WithMany(p => p.Errors)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("error_FK");
        });

        modelBuilder.Entity<Errorcomment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("errorcomment");

            entity.HasIndex(e => e.AccountId, "errorcomment_FK");

            entity.HasIndex(e => e.ErrorId, "errorcomment_FK_1");

            entity.Property(e => e.CommentId).HasColumnName("comment_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(45)
                .HasColumnName("comment");
            entity.Property(e => e.ErrorId).HasColumnName("error_id");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Account).WithMany(p => p.Errorcomments)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("errorcomment_FK");

            entity.HasOne(d => d.Error).WithMany(p => p.Errorcomments)
                .HasForeignKey(d => d.ErrorId)
                .HasConstraintName("errorcomment_FK_1");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PRIMARY");

            entity.ToTable("project");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");

            entity.HasMany(d => d.Accounts).WithMany(p => p.Projects)
                .UsingEntity<Dictionary<string, object>>(
                    "Collaborator",
                    r => r.HasOne<Account>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("collaborator_FK"),
                    l => l.HasOne<Project>().WithMany()
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("collaborator_FK_1"),
                    j =>
                    {
                        j.HasKey("ProjectId", "AccountId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("collaborator");
                        j.HasIndex(new[] { "AccountId" }, "collaborator_FK");
                        j.IndexerProperty<int>("ProjectId").HasColumnName("project_id");
                        j.IndexerProperty<int>("AccountId").HasColumnName("account_id");
                    });
        });

        modelBuilder.Entity<Projectcomment>(entity =>
        {
            entity.HasKey(e => e.ProjectCommentId).HasName("PRIMARY");

            entity.ToTable("projectcomment");

            entity.HasIndex(e => e.ProjectId, "projectcomment_FK");

            entity.HasIndex(e => e.AccountId, "projectcomment_FK_1");

            entity.Property(e => e.ProjectCommentId).HasColumnName("project_comment_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(45)
                .HasColumnName("comment");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Account).WithMany(p => p.Projectcomments)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("projectcomment_FK_1");

            entity.HasOne(d => d.Project).WithMany(p => p.Projectcomments)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("projectcomment_FK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
