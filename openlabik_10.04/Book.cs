using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlabik_10._04
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string sTitle, int iPages)
        {
            this.title = sTitle;
            this.pages = iPages;
            category = "-1";
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string sTitle, int iPages, string sCategory, string sAuthor, int iReleaseDate)
        {
            this.title = sTitle;
            this.pages = iPages;
            this.category = sCategory;
            this.author = sAuthor;
            this.releaseDate = iReleaseDate;
        }
        public string Title { get { return title; } set { title = value; } }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = pages = value <= 0 ? 1 : value;
            }
        }
        public string Category { get { return category; } set { category = value; } }
        public string Author { get { return author; } set { author = value; } }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;

            }
            set
            {
                releaseDate = releaseDate = value <= 1450 || value >= 2021 ? -1 : value;
            }
        }
        public override string ToString()
        {
            return String.Format($"\n{title}\n{pages}\n{category}\n{author}\n{releaseDate}\n");
        }
    }
}