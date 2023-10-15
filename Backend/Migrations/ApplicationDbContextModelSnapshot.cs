﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Backend.Data.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

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
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

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
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cottage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CostPerDay = 50.00m,
                            DateAdded = new DateTime(2023, 10, 13, 10, 11, 36, 209, DateTimeKind.Local).AddTicks(9828),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            IsElectricity = false,
                            IsSauna = false,
                            PictureUrl = "img/cottage1.jpeg",
                            Rooms = 0,
                            Title = "Foo"
                        },
                        new
                        {
                            Id = 2,
                            CostPerDay = 250.00m,
                            DateAdded = new DateTime(2023, 10, 13, 10, 11, 36, 210, DateTimeKind.Local).AddTicks(33),
                            IsElectricity = false,
                            IsSauna = false,
                            PictureUrl = "img/cottage2.jpeg",
                            Rooms = 0,
                            Title = "Bar"
                        });
                });

            modelBuilder.Entity("Backend.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("HomeAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

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

                    b.Navigation("HomeAddress");
                });

            modelBuilder.Entity("Backend.Data.Reservation", b =>
                {
                    b.HasOne("Backend.Data.Cottage", "Cottage")
                        .WithMany("Reservations")
                        .HasForeignKey("CottageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cottage");
                });

            modelBuilder.Entity("Backend.Data.Cottage", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
