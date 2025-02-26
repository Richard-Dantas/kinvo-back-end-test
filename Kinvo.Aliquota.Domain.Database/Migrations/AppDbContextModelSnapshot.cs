﻿// <auto-generated />
using System;
using Kinvo.Aliquota.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kinvo.Aliquota.Domain.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.Clients.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.DateIncomeApplications.DateIncomeApplication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<long>("AppliedValue")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IncomeApplicationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IncomeApplicationId");

                    b.ToTable("DateIncomeApplications");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.DateWithdrawals.DateWithdrawal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("IncomeApplicationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("WithdrawalValue")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IncomeApplicationId");

                    b.ToTable("DateWithdrawals");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.IncomeApplications.IncomeApplication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<long>("AppliedValue")
                        .HasColumnType("bigint");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DailyProfit")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalProfit")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductId");

                    b.ToTable("IncomeApplications");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Income")
                        .HasColumnType("real");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.DateIncomeApplications.DateIncomeApplication", b =>
                {
                    b.HasOne("Kinvo.Aliquota.Domain.Entities.IncomeApplications.IncomeApplication", null)
                        .WithMany("DateIncomeApplication")
                        .HasForeignKey("IncomeApplicationId");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.DateWithdrawals.DateWithdrawal", b =>
                {
                    b.HasOne("Kinvo.Aliquota.Domain.Entities.IncomeApplications.IncomeApplication", null)
                        .WithMany("DateWithdrawal")
                        .HasForeignKey("IncomeApplicationId");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.IncomeApplications.IncomeApplication", b =>
                {
                    b.HasOne("Kinvo.Aliquota.Domain.Entities.Clients.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kinvo.Aliquota.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Kinvo.Aliquota.Domain.Entities.IncomeApplications.IncomeApplication", b =>
                {
                    b.Navigation("DateIncomeApplication");

                    b.Navigation("DateWithdrawal");
                });
#pragma warning restore 612, 618
        }
    }
}
