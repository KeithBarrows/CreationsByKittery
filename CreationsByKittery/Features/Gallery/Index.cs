using System.Collections.Generic;
using System.Linq;
using MediatR;
using Sol3.Site.Repository;
using Sol3.Site.Repository.CreationsByKittery;

namespace CreationsByKittery.Features.Gallery
{
    public class Index
    {
        public class Query : IRequest<Result>
        {
            public int Id { get; set; } 
            public string FilePath { get; set; }
            
        }

        public class Result
        {
            public  PinterestGalleryDomainModel GalleryInfo { get; set; }
            public List<GalleryDomainModel> ButtonList { get; set; }
        }


        public class QueryHandler : IRequestHandler<Query, Result>
        {
            public QueryHandler() { }

            public Result Handle(Query message)
            {
                var galleryList = JsonFileHandler.LoadFromFile<List<PinterestGalleryDomainModel>>(message.FilePath);
                var response = new Result
                {
                    GalleryInfo = galleryList.FirstOrDefault(a => a.Id == message.Id),
                    ButtonList = galleryList.ToModel()
                };

                return response;
            }
        }
    }

    internal static class IndexExtensions
    {
        internal static List<GalleryDomainModel> ToModel(this List<PinterestGalleryDomainModel> source)
        {
            return source.Select(q => new GalleryDomainModel
            {
                Id = q.Id,
                CssClass = q.CssClass,
                Description = q.Description,
                Title = q.Title
            }).ToList();
        }
    }
}