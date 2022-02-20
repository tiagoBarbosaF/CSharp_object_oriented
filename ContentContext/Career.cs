using System.Collections.Generic;

namespace TiagoPortal.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string uri) : base(title, uri)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;
    }
}