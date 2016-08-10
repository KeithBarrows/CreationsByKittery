using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Sol3.Site.Repository;
using Sol3.Site.Repository.CreationsByKittery;

namespace CreationsByKittery.Features.Home
{
    public partial class HomeController : Controller
    {
        public ActionResult Index()
        {
            //CreateGalleyList();
            return View();
        }

        private void CreateGalleyList()
        {
            var galleries = new List<PinterestGalleryDomainModel>
            {
                new PinterestGalleryDomainModel
                {
                    Id = 0,
                    Title = "Victorian",
                    Description = "Vistorian Era",
                    Url = "https://www.pinterest.com/KitteryBarrows/victorion-clothing/",
                    CssClass = "button sepia"
                },
                new PinterestGalleryDomainModel
                {
                    Id = 1,
                    Title = "Clothing Dreams",
                    Description = "Clothing dreams and ideas",
                    Url = "https://www.pinterest.com/keithbarrows/clothing-dreams-and-ideas/",
                    CssClass = "button sepia"
                },
                new PinterestGalleryDomainModel
                {
                    Id = 2,
                    Title = "Vintage",
                    Description = "Vintage and Rockabilly",
                    Url = "https://www.pinterest.com/KitteryBarrows/vintage-and-rockabilly/",
                    CssClass = "button sepia"
                },
                new PinterestGalleryDomainModel
                {
                    Id = 3,
                    Title = "Steampunk",
                    Description = "Steampunk Ideas",
                    Url = "https://www.pinterest.com/KitteryBarrows/steampunk-ideas/",
                    CssClass = "button sepia"
                },
            };

            var saveFile = $"{Request.PhysicalApplicationPath}\\PinterestGallery.json";
            JsonFileHandler.SaveToFile(saveFile, galleries);
        }
    }
}