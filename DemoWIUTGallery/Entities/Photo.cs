using DemoWIUTGallery.Interfaces.Entities;

namespace DemoWIUTGallery.Entities
{
    public class Photo : IPhoto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
