﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workLogger.Data;

namespace workLogger.Migrations
{
    [DbContext(typeof(WorkLoggerContext))]
    partial class WorkLoggerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("workLogger.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("HoursAvailableToWork")
                        .HasColumnType("float");

                    b.Property<float>("HoursRemaining")
                        .HasColumnType("float");

                    b.Property<int>("HoursRequiredByBim")
                        .HasColumnType("int");

                    b.Property<float>("HoursWorked")
                        .HasColumnType("float");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfReviews")
                        .HasColumnType("int");

                    b.Property<long>("ProjectNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("ReviewHours")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("workLogger.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("workLogger.Models.Task", b =>
                {
                    b.HasOne("workLogger.Models.User", null)
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
