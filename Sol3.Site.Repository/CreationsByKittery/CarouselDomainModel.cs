using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol3.Site.Repository.CreationsByKittery
{
    public class CarouselDomainModel
    {
        public int Id { get; set; }
        public string ImageSource { get; set; }
        public string ImageMinHeight { get; set; }
        public string ImageMaxHeight { get; set; }
        public string ImageHeader { get; set; }
        public string ImageText { get; set; }
        public string TextColor { get; set; }
    }
}
