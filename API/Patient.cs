using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    [Serializable]
    public class Patient
    {
        private static readonly string urlPatientList = "https://9zld4zwegj.execute-api.us-east-1.amazonaws.com/dev/challenge/start.json";

        public Patient()
        {
            PatientList = new PatientList();
        }

        [JsonProperty("population")]
        public PatientList PatientList { get; set; }

        public List<PatientList> GetPatientsList(string token)
        {
            List<PatientList> pLists = new List<PatientList>();

            WebClient webClient = new WebClient();

            try
            {
                webClient.Headers["Authorization"] = token;
                var response = webClient.DownloadString(urlPatientList);

                var responseObj = JsonConvert.DeserializeObject<PatientResponse>(response);
                pLists = responseObj.Lists;
            }
            catch (Exception e)
            {

            }

            return pLists;
        }
    }
}
