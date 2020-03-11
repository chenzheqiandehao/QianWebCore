﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Qian.Shop.Core;

namespace Qian.Shop.Core.Migrations
{
    [DbContext(typeof(QianContext))]
    [Migration("20200227123518_UpdBooks")]
    partial class UpdBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Qian.Shop.Core.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BookID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("AuthorsName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("BookContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookImg")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("BookState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("(1)");

                    b.Property<string>("BookType")
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<decimal?>("GreatPrice")
                        .HasColumnType("money");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit");

                    b.Property<decimal?>("MarketPrice")
                        .HasColumnType("money");

                    b.Property<decimal?>("PromotionPrice")
                        .HasColumnType("money");

                    b.Property<decimal?>("SeckillPrice")
                        .HasColumnType("money");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

                    b.Property<string>("Suit")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("BookId")
                        .HasName("PK__Books__3DE0C227904E0DD7");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.Managers", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ManagerID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("ManagerId")
                        .HasName("PK__Managers__3BA2AA812C552E4D");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.OrderItems", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ItemID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnName("BookID")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal?>("ItemPrice")
                        .HasColumnType("money");

                    b.Property<short?>("ItemProperty")
                        .HasColumnType("smallint");

                    b.Property<short?>("ItemSuit")
                        .HasColumnType("smallint");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.HasKey("ItemId")
                        .HasName("PK__OrderIte__727E83EB2AA7F3C6");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("ConsigneeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ConsigneeName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("ConsigneePhone")
                        .IsRequired()
                        .HasColumnType("varchar(26)")
                        .HasMaxLength(26)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<short>("OrderStatus")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("Osprice")
                        .HasColumnName("OSPrice")
                        .HasColumnType("money");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ReceivingDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__C3905BAF658FF3AF");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.ShopCars", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CarID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnName("BookID")
                        .HasColumnType("int");

                    b.Property<short?>("Nums")
                        .HasColumnType("smallint");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("CarId")
                        .HasName("PK__ShopCars__68A0340E8338EA71");

                    b.HasIndex("UserId");

                    b.ToTable("ShopCars");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Provice")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC1CA0FE21");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.Orders", b =>
                {
                    b.HasOne("Qian.Shop.Core.Models.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Orders__UserID__412EB0B6");
                });

            modelBuilder.Entity("Qian.Shop.Core.Models.ShopCars", b =>
                {
                    b.HasOne("Qian.Shop.Core.Models.Users", "User")
                        .WithMany("ShopCars")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__ShopCars__UserID__46E78A0C");
                });
#pragma warning restore 612, 618
        }
    }
}