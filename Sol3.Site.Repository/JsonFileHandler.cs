using System.IO;
using Newtonsoft.Json;

namespace Sol3.Site.Repository
{
    public static class JsonFileHandler
    {
        public static T LoadFromFile<T>(string fileName) where T : class, new()
        {
            using (var file = File.OpenText(fileName))
            {
                var serializer = new JsonSerializer();
                var model = (T) serializer.Deserialize(file, typeof (T));
                return model;
            }
        }

        public static bool SaveToFile<T>(string fileName, T model) where T : class
        {
            try
            {
                using (var file = File.CreateText(fileName))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(file, model);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
