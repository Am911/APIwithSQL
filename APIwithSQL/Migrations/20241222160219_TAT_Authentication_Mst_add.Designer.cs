﻿// <auto-generated />
using System;
using APIwithSQL.SQLContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIwithSQL.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20241222160219_TAT_Authentication_Mst_add")]
    partial class TAT_Authentication_Mst_add
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIwithSQL.Models.Authentication", b =>
                {
                    b.Property<int>("UserAuthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAuthId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAuthId");

                    b.ToTable("TAT_Authentication_Mst");
                });

            modelBuilder.Entity("APIwithSQL.Models.VehicleType", b =>
                {
                    b.Property<int>("VehicleType_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleType_ID"));

                    b.Property<DateTime>("CretaedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VehicleEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("VehicleTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleType_ID");

                    b.ToTable("TAT_VehicleType_Mst");
                });
#pragma warning restore 612, 618
        }
    }
}
