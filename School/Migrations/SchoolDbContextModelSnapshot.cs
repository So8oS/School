﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Models;

#nullable disable

namespace School.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("School.Models.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RankId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("School.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("School.Models.SubjectRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RankId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectRanks");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RankId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.HasOne("School.Models.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("School.Models.SubjectRank", b =>
                {
                    b.HasOne("School.Models.Rank", "Rank")
                        .WithMany("SubjectRank")
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Models.Subject", "Subject")
                        .WithMany("SubjectRank")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rank");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.HasOne("School.Models.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("School.Models.Rank", b =>
                {
                    b.Navigation("SubjectRank");
                });

            modelBuilder.Entity("School.Models.Subject", b =>
                {
                    b.Navigation("SubjectRank");
                });
#pragma warning restore 612, 618
        }
    }
}
