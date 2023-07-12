using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EFClasses
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; } = string.Empty;
        public int RateStars { get; set; }
        public string Comment { get; set; } = string.Empty;


        //relationships
        public int BookId { get; set; }

    }
}
