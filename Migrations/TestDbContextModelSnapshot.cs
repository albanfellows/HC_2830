﻿// <auto-generated />
using System;
using EnumFilterTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnumFilterTest.Migrations
{
    [DbContext(typeof(TestDbContext))]
    partial class TestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EnumFilterTest.TestObject", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BadEnumField")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BadNullableEnumField")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("DecimalField")
                        .HasColumnType("TEXT");

                    b.Property<int>("GoodEnumField")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GoodNullableEnumField")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StringField")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestObjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BadEnumField = 1,
                            BadNullableEnumField = 1,
                            DecimalField = 1.2345m,
                            GoodEnumField = 1,
                            GoodNullableEnumField = 1,
                            StringField = "First Object"
                        },
                        new
                        {
                            Id = 2,
                            BadEnumField = 2,
                            BadNullableEnumField = 2,
                            DecimalField = 12.345m,
                            GoodEnumField = 2,
                            GoodNullableEnumField = 2,
                            StringField = "Second Object"
                        },
                        new
                        {
                            Id = 3,
                            BadEnumField = 3,
                            BadNullableEnumField = 3,
                            DecimalField = 123.45m,
                            GoodEnumField = 3,
                            GoodNullableEnumField = 3,
                            StringField = "Third Object"
                        },
                        new
                        {
                            Id = 4,
                            BadEnumField = 0,
                            BadNullableEnumField = 0,
                            DecimalField = 1234.5m,
                            GoodEnumField = 0,
                            GoodNullableEnumField = 0,
                            StringField = "Another Object"
                        },
                        new
                        {
                            Id = 5,
                            BadEnumField = 3,
                            BadNullableEnumField = 3,
                            DecimalField = 12345m,
                            GoodEnumField = 3,
                            GoodNullableEnumField = 3,
                            StringField = "Final Object"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}