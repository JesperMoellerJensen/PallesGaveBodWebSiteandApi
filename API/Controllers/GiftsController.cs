using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/gifts")]
    public class GiftsController : Controller
    {
        private IGiftRepository _giftRepository;

        public GiftsController(IGiftRepository giftRepository)
        {
            _giftRepository = giftRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var gifts = _giftRepository.GetAll();
            return Ok(gifts);
        }

        [HttpGet("{giftNumber}")]
        public IActionResult GetGift(int giftNumber)
        {
            var gift = _giftRepository.GetGift(giftNumber);

            if (gift == null)
            {
                return NotFound();
            }

            return Ok(gift);
        }

        [HttpGet("gender")]
        public IActionResult GetGift(bool boy, bool girl)
        {
            var gifts = _giftRepository.GetAllByGender(boy, girl);

            return Ok(gifts);
        }

        [HttpPost]
        public IActionResult CreateGift([FromBody] GiftEntity giftEntity)
        {
            giftEntity.CreationDate = DateTime.Now;
            _giftRepository.CreateGift(giftEntity);
            if (!_giftRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request");
            }

            return NoContent();
        }
    }
}
