using LeagueManagerWebApp.Dto;
using LeagueManagerWebApp.Interfaces;
using LeagueManagerWebApp.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeagueManagerWebApp.Services
{
    public class HomeService : IHomeService
    {
        public async Task<DailyCardModel> RandomCard()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.scryfall.com/cards/random");
            var dailyCard = JsonConvert.DeserializeObject<DailyCardDto>(await response.Content.ReadAsStringAsync());
            var dbModel = new DailyCardModel
            {
                Name = dailyCard.name,
                ReleaseDate = dailyCard.released_at,
                ImgPath = dailyCard.image_uris.normal,
                TCGpath = dailyCard.purchase_uris.tcgplayer,
                CMpath = dailyCard.purchase_uris.cardmarket,
                CHpath = dailyCard.purchase_uris.cardhoader,
                price = dailyCard.eur,
                deckPath = dailyCard.related_uris.tcgplayer_decks
            };
            return dbModel;
        }
    }
}