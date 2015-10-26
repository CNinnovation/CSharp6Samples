using BooksSample.Framework;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        public Book(int bookId)
        {
            BookId = bookId;
            Title = string.Empty;
            Publisher = string.Empty;
        }

        public int BookId { get; }


        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _publisher;
        public string Publisher
        {
            get { return _publisher; }
            set { SetProperty(ref _publisher, value); }
        }


        public string Author { get; set; } = "Christian Nagel";

        // TODO: 07 - string interpolation
        public override string ToString() => $"{Title}, {Publisher}";
       

    }
}
