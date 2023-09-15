﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sikho_backend.Models;

#nullable disable

namespace sikho_backend.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230915022734_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("website_link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IndustryId = 1,
                            name = "Waymo",
                            type = 0,
                            website_link = "https://waymo.com/"
                        },
                        new
                        {
                            Id = 2,
                            IndustryId = 1,
                            name = "Cruise",
                            type = 0,
                            website_link = "https://getcruise.com/"
                        });
                });

            modelBuilder.Entity("sikho_backend.Models.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("cost")
                        .HasColumnType("int");

                    b.Property<string>("cost_source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("units")
                        .HasColumnType("int");

                    b.Property<string>("units_source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("DataPoints");
                });

            modelBuilder.Entity("sikho_backend.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cost_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revenue_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("unit_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Industries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            cost_title = "Average Cost per Ride",
                            revenue_title = "Estimated Total Sales",
                            type = 0,
                            unit_title = "Trips Completed"
                        },
                        new
                        {
                            Id = 2,
                            cost_title = "Sales per Location",
                            revenue_title = "Estimated Total Sales",
                            type = 1,
                            unit_title = "Number of Locations"
                        });
                });

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.HasOne("sikho_backend.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("sikho_backend.Models.DataPoint", b =>
                {
                    b.HasOne("sikho_backend.Models.Company", "Company")
                        .WithMany("DataPoints")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.Navigation("DataPoints");
                });

            modelBuilder.Entity("sikho_backend.Models.Industry", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
