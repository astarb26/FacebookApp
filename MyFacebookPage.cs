using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;

namespace BasicFacebookFeatures
{
    public enum DisplayOption
    {
        Name,
        Likes,
        Id,
        Category,
        All
    }

    public class MyFacebookPage : FacebookPage
    {
        private User m_LoggedInUser;
        private ListBox listBoxPages;

        public MyFacebookPage(User i_LoggedInUser, ListBox listBoxPages)
        {
            m_LoggedInUser = i_LoggedInUser;
            this.listBoxPages = listBoxPages;
        }

        protected override List<FacebookPageInfo> FetchPages()
        {
            var pages = new List<FacebookPageInfo>();

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    string pageId = page.Id;
                    string pageName = page.Name;
                    string pageCategory = page.Category;
                    long pageLike = page.LikesCount ?? 0;
                    var pageInfo = new FacebookPageInfo(pageId, pageName, pageCategory, pageLike);
                    pages.Add(pageInfo);
                }
            }
            catch (FacebookApiException ex)
            {
                Console.WriteLine($"Error fetching pages: {ex.Message}");
            }

            return pages;
        }

        public new List<FacebookPageInfo> GetPages()
        {
            var pages = FetchPages();
            ProcessPages(pages);
            return pages;
        }

        protected override void ProcessPages(List<FacebookPageInfo> pages)
        {
        }

        public void DisplayPages(List<FacebookPageInfo> pages, DisplayOption displayOption)
        {
            listBoxPages.Items.Clear();

            foreach (var page in pages)
            {
                string pageText = GetPageDisplayText(page, displayOption);
                listBoxPages.Items.Add(pageText);
            }
        }

        private string GetPageDisplayText(FacebookPageInfo page, DisplayOption displayOption)
        {
            string pageText = string.Empty;
            switch (displayOption)
            {
                case DisplayOption.Name:
                    pageText = $"Name: {page.Name}";
                    break;
                case DisplayOption.Likes:
                    pageText = $"Name: {page.Name} Likes: {page.LikesCount}";
                    break;
                case DisplayOption.Id:
                    pageText = $"Name: {page.Name} Id: {page.Id}";
                    break;
                case DisplayOption.Category:
                    pageText = $"Name: {page.Name} Category: {page.Category}";
                    break;
                case DisplayOption.All:
                    pageText = $"Name: {page.Name} Likes: {page.LikesCount} Id: {page.Id} Category: {page.Category}";
                    break;
                default:
                    pageText = $"Name: {page.Name}";
                    break;
            }

            return pageText;
        }
    }
}
