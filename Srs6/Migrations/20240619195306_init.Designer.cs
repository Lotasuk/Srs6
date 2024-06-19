﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Srs6.DB;

#nullable disable

namespace Srs6.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240619195306_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Srs6.DB.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Srs6.DB.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("roleId")
                        .HasColumnType("integer");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Srs6.DB.Teacher", b =>
                {
                    b.HasOne("Srs6.DB.Role", "Role")
                        .WithMany("teachers")
                        .HasForeignKey("roleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Srs6.DB.Role", b =>
                {
                    b.Navigation("teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
