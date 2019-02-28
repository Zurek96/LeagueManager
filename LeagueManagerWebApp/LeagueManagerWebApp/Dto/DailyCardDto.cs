namespace LeagueManagerWebApp.Dto
{
    public class DailyCardDto
    {
        public ImageUrisDto image_uris { get; set; }
        public string name { get; set; }
        public string released_at { get; set; }
        public PurchaseUrisDto purchase_uris { get; set; }
        public string eur { get; set; }
        public RelatedUrisDto related_uris { get; set; }
    }
}