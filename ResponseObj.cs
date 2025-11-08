using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

        [JsonProperty("ordinal")]
        public string Ordinal { get; set; }

        [JsonProperty("numberOfDigits_numeric")]
        public int NumberOfDigitsnumeric { get; set; }

        [JsonProperty("numberOfDigits_words")]
        public string NumberOfDigitswords { get; set; }

        [JsonProperty("eachNumber")]
        public string[] EachNumber { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
