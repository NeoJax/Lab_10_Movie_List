using System;
namespace Lab_10_Movie_List
{
    public class Movie
    {
        #region fields
        private string _title;
        private string _category;
        #endregion

        #region properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        #endregion

        #region methods
        public Movie()
        {
        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }
        #endregion
    }
}
