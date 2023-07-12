using EFCoreFundamentals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFundamentals.Abilities
{
    public static class Abilities
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())
            {
                foreach (var book in db.Books!.AsNoTracking().Include(book => book.Author))
                {
                    var webUrl = book.Author?.WebUrl == null ? "- no URL given -" : book.Author.WebUrl;
                    Console.WriteLine($"{book.Title} by {book.Author?.Name}");
                    Console.WriteLine($"Published on {book.PublishedOn:dd-mm-yyyy}. {webUrl}");
                }

            }
        }

        public static void ChangeWebUrl()
        {
            Console.WriteLine("New URL for Quantum Networking > ");
            var newWebUrl = Console.ReadLine();

            using (var db = new AppDbContext())
            {
                var singleBook = db.Books?.Include(book => book.Author).Single(book => book.Title == "Quantum Networking");

                singleBook!.Author.WebUrl = newWebUrl ?? "";
                db.SaveChanges();
                Console.WriteLine("... Changes have been  saved.");
            }
            ListAll();
        }
    }
}
