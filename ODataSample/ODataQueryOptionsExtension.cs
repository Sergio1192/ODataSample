using Microsoft.AspNet.OData.Extensions;
using ODataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.AspNet.OData.Query
{
    public static class ODataQueryOptionsExtension
    {
        public static ResponseModel<T> ApplyTo<T>(this ODataQueryOptions<T> filter, IEnumerable<T> data)
        {
            var response = filter.ApplyTo(data.AsQueryable());
            var count = filter.Request.ODataFeature().TotalCount;

            return new ResponseModel<T>() { Value = response.Cast<T>(), TotalCount = Convert.ToInt16(count) };
        }
    }
}
