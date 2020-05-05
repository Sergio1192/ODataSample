using Microsoft.AspNet.OData.Extensions;
using ODataSample.Models;
using System;
using System.Collections;
using System.Linq;

namespace Microsoft.AspNet.OData.Query
{
    public static class ODataQueryOptionsExtension
    {
        public static ResponseModel<dynamic> ApplyTo(this ODataQueryOptions filter, IEnumerable data)
        {
            var response = filter.ApplyTo(data.AsQueryable());
            var count = filter.Request.ODataFeature().TotalCount;

            return new ResponseModel<dynamic>() { Value = response.Cast<dynamic>(), TotalCount = Convert.ToInt32(count) };
        }
    }
}
