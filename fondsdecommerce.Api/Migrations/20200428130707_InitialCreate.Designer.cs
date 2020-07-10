﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fondsdecommerce.Repository;

namespace fondsdecommerce.Api.Migrations
{
    [DbContext(typeof(ExchangeContext))]
    [Migration("20200428130707_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("fondsdecommerce.Repository.Domain.Achalandage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfClient")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Achalandage");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Achalandage");
                });

            modelBuilder.Entity("fondsdecommerce.Repository.Domain.Commerce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AchalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistreCommerce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AchalId");

                    b.ToTable("Commerces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Walmart",
                            RegistreCommerce = "91AD"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CBI",
                            RegistreCommerce = "96SR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Puma",
                            RegistreCommerce = "105UC"
                        });
                });

            modelBuilder.Entity("fondsdecommerce.Repository.Domain.Client", b =>
                {
                    b.HasBaseType("fondsdecommerce.Repository.Domain.Achalandage");

                    b.Property<int?>("AchalandageId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typ")
                        .HasColumnType("int");

                    b.HasIndex("AchalandageId");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("fondsdecommerce.Repository.Domain.Commerce", b =>
                {
                    b.HasOne("fondsdecommerce.Repository.Domain.Achalandage", "Achal")
                        .WithMany()
                        .HasForeignKey("AchalId");
                });

            modelBuilder.Entity("fondsdecommerce.Repository.Domain.Client", b =>
                {
                    b.HasOne("fondsdecommerce.Repository.Domain.Achalandage", null)
                        .WithMany("Clients")
                        .HasForeignKey("AchalandageId");
                });
#pragma warning restore 612, 618
        }
    }
}