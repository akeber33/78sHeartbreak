using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _78sHeartbreak.Models
{
    public class KanyeRespostas
    {
        [JsonPropertyName("quote")]
        public string? Frase { get; set; }
    }
}