using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Services
{
    public static class GiftContextExtensions
    {
        public static void EnsureSeedDataForContext(this GiftContext context)
        {
            if (context.Gifts.Any())
            {
                return;
            }

            var gifts = new List<GiftEntity>
            {

            }

            context.AddRange(auctionItems);
            context.SaveChanges();
        }
    }
}
}
