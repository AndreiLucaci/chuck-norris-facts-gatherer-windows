using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using ChuckNorrisFacts.Win.Models;
using Newtonsoft.Json;

namespace ChuckNorrisFacts.Win.Controllers
{
	public class FactsGathererController
	{
		private readonly HttpClient _client;

		public FactsGathererController(HttpClient client)
		{
			_client = client;
		}

		public async Task<FactModel> GatherOne()
		{
			using (var response = await _client.SendAsync(CreateRandomFactsRequest()))
			{
				var responseString = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<FactModel>(responseString);
			}
		}

		private static HttpRequestMessage CreateRandomFactsRequest()
			=> new HttpRequestMessage
			{
				RequestUri = new Uri(ConfigurationManager.AppSettings["RandomApiUrl"]),
				Method = HttpMethod.Get
			};
	}
}
