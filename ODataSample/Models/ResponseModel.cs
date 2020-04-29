using System.Collections.Generic;

namespace ODataSample.Models
{
    public class ResponseModel<T>
    {
        public IEnumerable<T> Value { get; set; }
        public int TotalCount { get; set; }
    }
}
