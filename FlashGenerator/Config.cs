using System.Xml.Serialization;

namespace FlashGenerator
{
    public class Config
    {
        private static Config? instance;
        public static Config Get
        {
            get
            {
                if(instance == null)
                {
                    throw new InvalidOperationException("Config.Initialize must be run before it can be read from.");
                }
                return instance;
            }
        }

        public string FlashOutputPath { get; set; }
        public string OA3OutputPath { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public List<Brand> Brands { get; set; }

        private string FilePath;
        private XmlSerializer serializer;


        public static void Initialize(string filePath)
        {
            instance ??= new Config();
            instance.Load(filePath);
        }

        public static void Add(Manufacturer manufacturer)
        {
            if (instance == null)
            {
                throw new InvalidOperationException("Config.Initialize must be run before you can use this function.");
            }
            instance.Manufacturers.Add(manufacturer);
            instance.Write();
        }

        public static void Add(Brand brand)
        {
            if (instance == null)
            {
                throw new InvalidOperationException("Config.Initialize must be run before you can use this function.");
            }
            instance.Brands.Add(brand);
            instance.Write();
        }

        public static void Set(string? flashOutputPath = null, string? oa3OutputPath = null)
        {
            if (instance == null)
            {
                throw new InvalidOperationException("Config.Initialize must be run before you can use this function.");
            }
            if (oa3OutputPath != null)
            {
                instance.OA3OutputPath = oa3OutputPath;
            }
            if (flashOutputPath != null)
            {
                instance.FlashOutputPath = flashOutputPath;
            }
            instance.Write();
        }

        protected Config()
        {
            FlashOutputPath = string.Empty;
            OA3OutputPath = string.Empty;
            FilePath = string.Empty;

            Manufacturers = new List<Manufacturer>();
            Brands = new List<Brand>();

            serializer = new XmlSerializer(typeof(Config));
        }

        private void Load(string filePath)
        {
            FilePath = filePath;
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            Config config = serializer.Deserialize(fileStream) as Config ?? throw new Exception();
            setData(config);
            fileStream.Close();
        }
        
        private void Write()
        {
            FileStream fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fileStream, this);
            fileStream.Close();
        }

        private void setData(Config data)
        {
            FlashOutputPath = data.FlashOutputPath;
            OA3OutputPath = data.OA3OutputPath;
            Manufacturers = data.Manufacturers;
            Brands = data.Brands;
        }
    }
}
