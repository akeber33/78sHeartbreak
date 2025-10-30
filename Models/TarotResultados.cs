using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _78sHeartbreak.Models
{
    public class TarotResultados
    {
        public string? UsuarioSentimento { get; set; }
        public List<TarotCartas> CartaSorteada { get; set; } = new();        
        public string? KanyeFrase { get; set; }
    }
}