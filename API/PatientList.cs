using Newtonsoft.Json;
using System;

namespace API
{
    [Serializable]
    public class PatientList
    {
        [JsonProperty("populationId")]
        public string Id { get; set; }
        [JsonProperty("population")]
        public string Population { get; set; }
        [JsonProperty("timestamp")]
        public int TimeStamp { get; set; }

    }
}