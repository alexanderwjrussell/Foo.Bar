using System.Collections.Generic;

namespace Foo.Bar.API.Models.Responses
{
    /// <summary>
    /// Response model used by SearchMenu api endpoint
    /// </summary>
    public class SearchMenuResponse
    {
        /// <example>10</example>
        public int Size { get; set; }

        /// <example>0</example>
        public int Offset { get; set; }

        /// <summary>
        /// Contains the items returned from the search
        /// </summary>
        public List<SearchMenuResponseItem> Results { get; set; }
    }
}
