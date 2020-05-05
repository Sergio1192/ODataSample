using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ODataSample
{
    public class IncludeCountAttribute : Attribute, IResourceFilter
    {
        private const string COUNT = "$count";
        private const string TOP = "$top";
        private const string SKIP = "$skip";
        private const bool VALUE = true;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Nothing
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var query = context.HttpContext.Request.Query;
            if (!query.ContainsKey(COUNT) && (query.ContainsKey(TOP) || query.ContainsKey(SKIP)))
                context.HttpContext.Request.QueryString = context.HttpContext.Request.QueryString.Add(new QueryString($"?{COUNT}={VALUE.ToString().ToLower()}"));
        }
    }
}
