/***********************************************************************
ABIE Development team
***********************************************************************/

using Newtonsoft.Json;
using System;

namespace Presidents.Entities
{
    public class PresidentDto
    {
        [JsonProperty("birthDay")]
        public DateTime BirthDay { get; set; }

        [JsonProperty("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonProperty("deathDay")]
        public DateTime? DeathDay { get; set; }

        [JsonProperty("deathPlace")]
        public string DeathPlace { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}