namespace DataLayer.EFClasses
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;


        //relationships

        public PriceOffer Promotion { get; set; } = new();
        public ICollection<Review>? Reviews { get; set; } 
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<BookAuthor>? AuthorsLink { get; set; }
    }
}
