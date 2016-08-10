using System.Web.Mvc;
using MediatR;
using Sol3.IoC;

namespace CreationsByKittery.Features.Gallery
{
    public partial class GalleryController : Controller //, IIsAutoRegistered
    {
        private readonly IMediator _mediator;
        public GalleryController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: Gallery
        [Route("Gallery/{id:int?}")]
        [HttpGet]
        public ActionResult Index(int? id)
        {
            var query = new Index.Query
            {
                Id = id ?? 1,
                FilePath = $"{Request.PhysicalApplicationPath}\\PinterestGallery.json"
            };
            var model = _mediator.Send(query);
            return View(model);
        }
    }
}