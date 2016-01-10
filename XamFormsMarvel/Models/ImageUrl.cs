using System;
using Newtonsoft.Json;

namespace XamFormsMarvel.Models
{
	public class ImageUrl
	{
		[JsonProperty("path")]
		public string Path { get; set; }
		[JsonProperty("extension")]
		public string Extension { get; set; }
	}
}

