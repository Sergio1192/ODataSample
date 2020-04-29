using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ODataSample
{
    public class IncludeCountAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Nothing
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!context.HttpContext.Request.Query.ContainsKey("$count"))
                context.HttpContext.Request.QueryString = context.HttpContext.Request.QueryString.Add(new QueryString("?$count=true"));
        }
    }
}
