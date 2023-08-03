namespace my_books.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Desc { get; set; }

        public bool IsRead { get; set; }
        public System.DateTime? DateRead { get; set; }
        public int? Rate { get; set; }

        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public System.DateTime dateadded { get; set; }

    }
}
