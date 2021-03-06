﻿using System;
using Newtonsoft.Json;
using POGOProtos.Enums;

namespace PogoLocationFeeder.API
{
    public class SniperInfoModel
    {
        [JsonProperty("ExpirationTimestamp")]
        public DateTime ExpirationTimestamp { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Id")]
        public PokemonId Id { get; set; } = PokemonId.Missingno;

        [JsonProperty("IV")]
        public double IV { get; set; }
    }
}