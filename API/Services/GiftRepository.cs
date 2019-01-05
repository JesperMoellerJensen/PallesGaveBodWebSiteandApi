using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Services
{
    public class GiftRepository : IGiftRepository
    {
        public List<GiftEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public GiftEntity GetGift(int giftNumber)
        {
            throw new NotImplementedException();
        }

        public List<GiftEntity> GetAllByGender(bool boy, bool girl)
        {
            throw new NotImplementedException();
        }
    }
}
