using System;
using TiagoPortal.SharedContext;

namespace TiagoPortal.ContentContext
{
    public abstract class Content : Base
    {
        protected Content(string title, string uri)
        {
            Title = title;
            Uri = uri;
        }

        
        public string Title { get; set; }
        public string Uri { get; set; }
    }
}