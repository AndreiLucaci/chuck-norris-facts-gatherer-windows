using Newtonsoft.Json;

namespace ChuckNorrisFacts.Win.Models
{
	public class FactModel
	{
		[JsonProperty("catetory")]
		public string Category { get; set; }

		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
