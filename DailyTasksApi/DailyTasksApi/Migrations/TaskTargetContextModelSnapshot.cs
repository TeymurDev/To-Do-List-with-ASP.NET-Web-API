﻿// <auto-generated />
using System;
using DailyTasksApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyTasksApi.Migrations
{
    [DbContext(typeof(TaskTargetContext))]
    partial class TaskTargetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DailyTasksApi.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("Duration");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new { Id = 1, CreationDate = new DateTime(2020, 1, 24, 10, 57, 54, 526, DateTimeKind.Local), Duration = 10, Name = "Learn Java" },
                        new { Id = 2, CreationDate = new DateTime(2020, 1, 24, 10, 57, 54, 528, DateTimeKind.Local), Duration = 5, Name = "Learn JS" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
