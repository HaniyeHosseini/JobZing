﻿// <auto-generated />
using System;
using JobZing.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobZing.Infra.Data.Migrations
{
    [DbContext(typeof(JobZingContext))]
    [Migration("20220928142114_add-relation-to-jobcategory")]
    partial class addrelationtojobcategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobZing.Domain.Models.JobAgg.JobCategory", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ParentID")
                        .HasColumnType("bigint");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("JobZing.Domain.Models.JobAgg.JobCategory", b =>
                {
                    b.HasOne("JobZing.Domain.Models.JobAgg.JobCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentID");

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
