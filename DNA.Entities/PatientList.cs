using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace DNA
{
    [Serializable]
    public class PatientList
    {
        [JsonProperty("email")]
        public int email { get; set; }

    }
}