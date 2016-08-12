using System.Collections.Generic;
using MediatR;
using Sol3.Site.Repository;
using Sol3.Site.Repository.CreationsByKittery;

namespace CreationsByKittery.Features.Home
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
            public List<CarouselDomainModel> CarouselList { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, Result>
        {
            public QueryHandler() { }

            public Result Handle(Query message)
            {
                var carouselList = JsonFileHandler.LoadFromFile<List<CarouselDomainModel>>(message.FilePath);
                var response = new Result
                {
                    CarouselList = carouselList
                };

                return response;
            }
        }

    }
}