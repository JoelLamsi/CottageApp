﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231002092923_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Backend.Data.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Backend.Data.Cottage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CostPerDay")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<bool>("IsElectricity")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSauna")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Cottages");
                });

            modelBuilder.Entity("Backend.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("HomeAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Backend.Data.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CottageId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CottageId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Backend.Data.Person", b =>
                {
                    b.HasOne("Backend.Data.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Data.Reservation", b =>
                {
                    b.HasOne("Backend.Data.Cottage", "Cottage")
                        .WithMany("Reservations")
                        .HasForeignKey("CottageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
