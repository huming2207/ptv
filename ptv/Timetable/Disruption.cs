﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ptv.Timetable
{
    [JsonObject()]
    public abstract class Disruption : Item
    {
        // TO-DO: THESE STUFF BELOW DOESN'T WORK AT ALL
        // COMPLETELY WRONG, SILLY ME...
        // NEED TO BE FIXED BY WRITING ANOTHER "ItemConverter"
        [JsonProperty(PropertyName = "disruption_id")]
        public string DisruptionId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string MessageURL { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName ="status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "publishedOn")]
        public DateTime PublishTime { get; set; }

        [JsonProperty(PropertyName = "fromDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "toDate")]
        public DateTime EndDate { get; set; }
    }
}
