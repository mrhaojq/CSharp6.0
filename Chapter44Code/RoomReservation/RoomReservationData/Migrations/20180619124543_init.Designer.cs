﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomReservationData;

namespace RoomReservationData.Migrations
{
    [DbContext(typeof(RoomReservationContext))]
    [Migration("20180619124543_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoomReservationContracts.RoomReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasMaxLength(30);

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("RoomName")
                        .HasMaxLength(30);

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Text")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("RoomReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
