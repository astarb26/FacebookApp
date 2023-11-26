using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public abstract class FacebookPage
    {
        protected abstract List<FacebookPageInfo> FetchPages();

        protected virtual void ProcessPages(List<FacebookPageInfo> pages)
        {
            // General processing logic for pages
        }

        protected virtual void DisplayPages(List<FacebookPageInfo> pages)
        {
            // Default implementation for displaying pages
        }

        public void GetPages()
        {
            var pages = FetchPages();
            ProcessPages(pages);
            DisplayPages(pages);
        }
    }
}