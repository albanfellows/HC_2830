using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnumFilterTest
{
    public class TestObject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public string StringField { get; set; }
        public decimal? DecimalField { get; set; }
        [GraphQLType(typeof(NonNullType<EnumType<TestEnum>>))] public TestEnum? BadNullableEnumField { get; set; }
        [GraphQLNonNullType]public TestEnum? GoodNullableEnumField { get; set; }
        [GraphQLType(typeof(EnumType<TestEnum>))] public TestEnum BadEnumField { get; set; }
        [GraphQLNonNullType]public TestEnum GoodEnumField { get; set; }
    }
}
