﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reservations.Infrastructure.Contexts;

namespace Reservations.Infrastructure.Migrations
{
    [DbContext(typeof(ReservationsContext))]
    [Migration("20190618175317_PluralizedCustomerTable")]
    partial class PluralizedCustomerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reservations.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Remarks");

                    b.Property<int>("Reservations");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Reservations.Domain.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<Guid?>("CustomerId");

                    b.Property<DateTime>("End");

                    b.Property<string>("Remark");

                    b.Property<DateTime>("Start");

                    b.Property<int>("Table");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Reservations.Domain.Models.Reservation", b =>
                {
                    b.HasOne("Reservations.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
