using System.Collections.Generic;
using TiagoPortal.ContentContext.Enums;

namespace TiagoPortal.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string uri, EContentLevel level) : base(title, uri)
        {
            Modules = new List<Module>();
            Level = level;
        }
        
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}