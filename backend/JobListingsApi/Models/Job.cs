namespace JobListingsApi.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image {  get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public DateTime Created_date { get; set; }
        public List<string> Tags { get; set; }
    }
}
