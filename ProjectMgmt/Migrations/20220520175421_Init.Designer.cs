﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMgmt.Models;

#nullable disable

namespace ProjectMgmt.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20220520175421_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectMgmt.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActualHours")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("EstimatedHours")
                        .HasColumnType("int");

                    b.Property<float>("PercentComplete")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HoursPerDay")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("HoursWorked")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Resource", b =>
                {
                    b.HasOne("ProjectMgmt.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Work", b =>
                {
                    b.HasOne("ProjectMgmt.Models.Project", null)
                        .WithMany("Works")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ProjectMgmt.Models.Resource", "Resource")
                        .WithMany("Works")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Project", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("ProjectMgmt.Models.Resource", b =>
                {
                    b.Navigation("Works");
                });
#pragma warning restore 612, 618
        }
    }
}
