using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnumFilterTest
{
    public class Query
    {
        [UsePaging(IncludeTotalCount=true), UseProjection, HotChocolate.Types.UseFiltering, HotChocolate.Types.UseSorting]
        public IQueryable<TestObject> GetObjectsOld([Service] TestDbContext context) => context.TestObjects;

        [UsePaging(IncludeTotalCount=true), UseProjection, HotChocolate.Data.UseFiltering, HotChocolate.Data.UseSorting]
        public IQueryable<TestObject> GetObjectsNew([Service] TestDbContext context) => context.TestObjects;
    }
}
