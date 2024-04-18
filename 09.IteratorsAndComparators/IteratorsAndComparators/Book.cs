namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book? other)
        {
            int yearsComparsopn = Year.CompareTo(other.Year);
            if (yearsComparsopn == 0)
            {
                return Title.CompareTo(other.Title);
            }
            return yearsComparsopn;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
