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
                new GiftEntity
                {
                    Title = "Bil",
                    Description = "Den kører hurtigt",
                    CreationDate = DateTime.Now,
                    BoyGift = true,
                    GirlGift = false
                },
                new GiftEntity
                {
                    Title = "Dukke",
                    Description = "En flot en",
                    CreationDate = DateTime.Now,
                    BoyGift = false,
                    GirlGift = true
                },
                new GiftEntity
                {
                    Title = "Action-Man",
                    Description = "Han er stærk!",
                    CreationDate = DateTime.Now,
                    BoyGift = true,
                    GirlGift = false
                },
                new GiftEntity
                {
                    Title = "Dukkehus",
                    Description = "Stort flot hus",
                    CreationDate = DateTime.Now,
                    BoyGift = false,
                    GirlGift = true
                },
                new GiftEntity
                {
                    Title = "Tegne-Sæt",
                    Description = "72 farver og 350 sider!",
                    CreationDate = DateTime.Now,
                    BoyGift = true,
                    GirlGift = true
                }

            };

            context.AddRange(gifts);
            context.SaveChanges();
        }
    }
}

