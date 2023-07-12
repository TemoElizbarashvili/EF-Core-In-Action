using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EFClasses;

namespace DataLayer.EFClasses
{
    public static class BookExtension
    {
        public static IQueryable<BookListDto> MapBookToDto(this IQueryable<Book> books)
        {
            return books.Select(book => new BookListDto
            {
                BookId = book.BookId,
                Title = book.Title,
                Price = book.Price,
                PublishedOn = book.PublishedOn,
                ActualPrice = book.Promotion == null ? book.Price : book.Promotion.NewPrice,
                PromotionPromotionalText = book.Promotion == null ? null : book.Promotion.PromotionalText,
                AuthorsOrdered = string.Join(", ",
                    book.AuthorsLink!.OrderBy(ba => ba.Order).Select(ba => ba.Author.Name)),
                ReviewsCount = book.Reviews.Count(),
                ReviewsAverageVotes = book.Reviews.Select(review => (double?)review.RateStars).Average(),
                TagStrings = book.Tags.Select(x => x.TagId).ToArray(),

            });
        }
    }
}
