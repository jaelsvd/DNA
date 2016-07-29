using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace API
{
    [Serializable]
   public class PatientResponse
    {
        public PatientResponse()
        {
            Lists = new List<PatientList>();
        }

        [JsonProperty("email")]
        public List<PatientList> Lists { get; set; }

    }
}
