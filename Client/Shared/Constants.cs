﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXAirlines.Client.Shared
{

   public static class ConfigurationSettings
   {
       public static readonly string PostUrl = "https://localhost:9001/api/WebhookSubscription";
       public static readonly string PriceUpdateUrl = "https://localhost:9001/api/Flight";
       public static readonly string cssShow = "display:block";
       public static readonly string cssHide = "display:none";
       public static readonly string PriceUpdates = "PriceUpdates";
       public static readonly string DelayUpdates = "DelayUpdates";

   }

}
