namespace DemoWIUTGallery.Interfaces.Entities
{
    public interface IPhoto
    {
        Guid Id { get; set; }
        string Name { get; set; }
        byte[] Data { get; set; }
        string Description { get; set; }
        DateTimeOffset? CreatedDate { get; set; }
        DateTimeOffset UpdatedDate { get; set; }
    }
}
