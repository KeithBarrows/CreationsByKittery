using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MediatR;
using Sol3.Site.Repository;
using Sol3.Site.Repository.CreationsByKittery;

namespace CreationsByKittery.Features.Home
{
    public partial class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public ActionResult Index()
        {
            //CreateGalleyList();
            //CreateCarouselList();

            var query = new Index.Query { FilePath = $"{Request.PhysicalApplicationPath}\\HomeIndexCarousel.json" };
            var model = _mediator.Send(query);
            return View(model);
        }

        private void CreateCarouselList()
        {
            var list = new List<CarouselDomainModel>
            {
                new CarouselDomainModel
                {
                    Id = 0,
                    ImageSource = "/Content/images/carousel00.jpg",
                    ImageHeader = "Meet Kittery",
                    ImageText = "Hi!  I am Kittery......",
                    ImageMinHeight = "300px",
                    ImageMaxHeight = "300px"
                },
                new CarouselDomainModel
                {
                    Id = 1,
                    ImageSource = "/Content/images/carousel01.jpg",
                    ImageHeader = "Specialties",
                    ImageText = "Steampunk, Wedding Gowns, Vintage and Rockabilly, Renaissance and Victorian Periods.....",
                    ImageMinHeight = "300px",
                    ImageMaxHeight = "300px"
                },
                new CarouselDomainModel
                {
                    Id = 2,
                    ImageSource = "/Content/images/carousel02.jpg",
                    ImageHeader = "General",
                    ImageText = "General Alterations, Repairs, Scrubs.....",
                    ImageMinHeight = "300px",
                    ImageMaxHeight = "300px"
                },
            };
            var saveFile = $"{Request.PhysicalApplicationPath}\\HomeIndexCarousel.json";
            JsonFileHandler.SaveToFile(saveFile, list);
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