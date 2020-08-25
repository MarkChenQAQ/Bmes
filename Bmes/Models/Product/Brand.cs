using Bmes.Models.Shared;

namespace Bmes.Models.Product
{
    public class Brand : BaseObject
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MeteDescription { get; set; }
        public string MeteKeywords { get; set; }
        public BrandStatus BrandStatus { get; set; }

    }
}
