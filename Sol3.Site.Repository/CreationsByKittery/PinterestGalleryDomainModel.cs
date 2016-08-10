namespace Sol3.Site.Repository.CreationsByKittery
{
    public class PinterestGalleryDomainModel : GalleryDomainModel
    {
        public PinterestGalleryDomainModel()
        {
            DataPinDo = "embedBoard";
            DataPinBoardWidth = 400;
            DataPinScaleHeight = 240;
            DataPinScaleWidth = 80;
        }

        public string Url { get; set; }
        public string DataPinDo { get; set; }
        public int DataPinBoardWidth { get; set; }
        public int DataPinScaleHeight { get; set; }
        public int DataPinScaleWidth { get; set; }
    }
}
