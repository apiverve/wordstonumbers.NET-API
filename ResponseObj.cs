using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("number")]
    public string number { get; set; }

    [JsonProperty("words")]
    public string words { get; set; }

    [JsonProperty("ordinal")]
    public string ordinal { get; set; }

    [JsonProperty("numberOfDigits_numeric")]
    public int numberOfDigitsnumeric { get; set; }

    [JsonProperty("numberOfDigits_words")]
    public string numberOfDigitswords { get; set; }

    [JsonProperty("eachNumber")]
    public string[] eachNumber { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
