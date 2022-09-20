﻿// <auto-generated />
using System;
using ChatTP.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatTP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChatTP.Models.Messagge", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("idRoom")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<string>("messaggebody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("roomchatid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roomchatid");

                    b.ToTable("Messagges");
                });

            modelBuilder.Entity("ChatTP.Models.Room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("NameRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUserRoom")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ChatTP.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChatTP.Models.UserRoom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomChatsid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("RoomChatsid");

                    b.ToTable("UserRooms");
                });

            modelBuilder.Entity("ChatTP.Models.Messagge", b =>
                {
                    b.HasOne("ChatTP.Models.Room", "roomchat")
                        .WithMany("Messages")
                        .HasForeignKey("roomchatid");

                    b.Navigation("roomchat");
                });

            modelBuilder.Entity("ChatTP.Models.UserRoom", b =>
                {
                    b.HasOne("ChatTP.Models.Room", "RoomChats")
                        .WithMany()
                        .HasForeignKey("RoomChatsid");

                    b.Navigation("RoomChats");
                });

            modelBuilder.Entity("ChatTP.Models.Room", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
