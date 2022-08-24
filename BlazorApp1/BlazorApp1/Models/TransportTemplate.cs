namespace BlazorApp1.Models
{
    public class TransportTemplate
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public int LordPointId { get; set; }
        public int UnlordPointId { get; set; }

        public int LordRT { get; set; }
        public int UnlordRT { get; set; }
    }
}
