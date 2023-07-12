using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EFClasses
{
    public class BookListDto
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; }
        public decimal Price { get; set; }
        public decimal ActualPrice { get; set; }
        public string PromotionPromotionalText { get; set; } = string.Empty;
        public string AuthorsOrdered { get; set; } = string.Empty;
        public int ReviewsCount { get; set; }
        public double? ReviewsAverageVotes { get; set; }
        public string[] TagStrings { get; set; } = Array.Empty<string>();

    }
}
