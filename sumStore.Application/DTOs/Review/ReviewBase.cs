namespace sumStore.Application.DTOs.Review
{
    public class ReviewBase
    {
        public required string Title { get; set; }
        public string? Comment { get; set; }
        public required int Rating { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}
