using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Services
{
    public class GiftRepository : IGiftRepository
    {
        private GiftContext _context;

        public GiftRepository(GiftContext context)
        {
            _context = context;
        }

        public List<GiftEntity> GetAll()
        {
            return _context.Gifts.OrderBy(g => g.Title).ToList();
        }

        public GiftEntity GetGift(int giftNumber)
        {
            return _context.Gifts.FirstOrDefault(g => g.GiftNumber == giftNumber);
        }

        public List<GiftEntity> GetAllByGender(bool boy, bool girl)
        {
            return _context.Gifts.Where(g => g.BoyGift == boy & g.GirlGift == girl).ToList();
        }

        public void CreateGift(GiftEntity giftEntity)
        {
            _context.Gifts.Add(giftEntity);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
