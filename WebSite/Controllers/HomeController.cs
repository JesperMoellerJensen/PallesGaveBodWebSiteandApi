using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using WebSite.Helpers;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private IApiHelper _apiHelper;

        public HomeController(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
            _apiHelper.BaseUri = new Uri("http://localhost:52080");
        }

        [HttpGet]
        public IActionResult Index(bool boy, bool girl)
        {
            var giftsResult = new List<Gift>();
            if (!boy && !girl)
            {
                giftsResult = _apiHelper.Get<List<Gift>>("api/gifts");
            }

            if (boy && girl == false)
            {
                giftsResult = _apiHelper.Get<List<Gift>>("api/gifts/gender?boy=true");
            }

            if (boy == false && girl)
            {
                giftsResult = _apiHelper.Get<List<Gift>>("api/gifts/gender?girl=true");
            }

            if (boy && girl)
            {
                giftsResult = _apiHelper.Get<List<Gift>>("api/gifts/gender?boy=true&girl=true");
            }

            return View(giftsResult);
        }

        [HttpGet]
        public IActionResult CreateGift()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGift(Gift gift)
        {
            _apiHelper.Post(gift,"api/gifts");
            return Redirect("Index");
        }
    }
}
