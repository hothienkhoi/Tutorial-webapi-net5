﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApiApp.Data;

namespace MyWebApiApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230309061753_optimizecode")]
    partial class optimizecode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebApiApp.Data.HangHoaEntity", b =>
                {
                    b.Property<Guid>("MaHangHoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int?>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHangHoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaHangHoa");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("MyWebApiApp.Data.LoaiHoangHoaEntity", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiHangHoa");
                });

            modelBuilder.Entity("MyWebApiApp.Data.HangHoaEntity", b =>
                {
                    b.HasOne("MyWebApiApp.Data.LoaiHoangHoaEntity", "Loai")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaLoai");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("MyWebApiApp.Data.LoaiHoangHoaEntity", b =>
                {
                    b.Navigation("HangHoas");
                });
#pragma warning restore 612, 618
        }
    }
}