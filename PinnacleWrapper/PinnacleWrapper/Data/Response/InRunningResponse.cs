﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleWrapper.Data.Response
{
    public class InRunningResponse
    {
        [JsonProperty("sports")]
        public List<SportInRunning> InRunningSports { get; set; }
    }
}
