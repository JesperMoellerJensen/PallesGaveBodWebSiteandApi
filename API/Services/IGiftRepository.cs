using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Services
{
    public interface IGiftRepository
    {
        List<GiftEntity> GetAll();
        GiftEntity GetGift(int giftNumber);
        List<GiftEntity> GetAllByGender(bool boy, bool girl);
        void CreateGift(GiftEntity giftEntity);
        bool Save();
    }
}
