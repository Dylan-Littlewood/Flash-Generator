
namespace FlashGenerator
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string FlashPath { get; set; }
        public string OA3Path { get; set; }

        public Manufacturer(string name, string flashPath, string oa3Path) 
        {
            Name = name;
            FlashPath = flashPath;
            OA3Path = oa3Path;
        }
        public Manufacturer() 
        {
            Name = string.Empty;
            FlashPath = string.Empty;
            OA3Path = string.Empty;
        }
    }
}
