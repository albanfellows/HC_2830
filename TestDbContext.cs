using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnumFilterTest
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestObject>()
                .HasData(
                    new TestObject
                    {
                        Id = 1,
                        StringField = "First Object",
                        DecimalField = 1.2345m,
                        BadEnumField = TestEnum.First,
                        GoodEnumField = TestEnum.First,
                        BadNullableEnumField = TestEnum.First,
                        GoodNullableEnumField = TestEnum.First
                    },
                    new TestObject
                    {
                        Id = 2,
                        StringField = "Second Object",
                        DecimalField = 12.345m,
                        BadEnumField = TestEnum.Second,
                        GoodEnumField = TestEnum.Second,
                        BadNullableEnumField = TestEnum.Second,
                        GoodNullableEnumField = TestEnum.Second
                    },
                    new TestObject
                    {
                        Id = 3,
                        StringField = "Third Object",
                        DecimalField = 123.45m,
                        BadEnumField = TestEnum.Third,
                        GoodEnumField = TestEnum.Third,
                        BadNullableEnumField = TestEnum.Third,
                        GoodNullableEnumField = TestEnum.Third
                    },
                    new TestObject
                    {
                        Id = 4,
                        StringField = "Another Object",
                        DecimalField = 1234.5m,
                        BadEnumField = TestEnum.None,
                        GoodEnumField = TestEnum.None,
                        BadNullableEnumField = TestEnum.None,
                        GoodNullableEnumField = TestEnum.None
                    },
                    new TestObject
                    {
                        Id = 5,
                        StringField = "Final Object",
                        DecimalField = 12345m,
                        BadEnumField = TestEnum.Third,
                        GoodEnumField = TestEnum.Third,
                        BadNullableEnumField = TestEnum.Third,
                        GoodNullableEnumField = TestEnum.Third
                    }
                );
        }
        public DbSet<TestObject> TestObjects { get; set; }
    }
}
