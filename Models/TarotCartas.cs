using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _78sHeartbreak.Models
{
    public class TarotCartas
    {
        [Key]
        public int CartaId { get; set; }
        public string? Nome { get; set; }        
        public int Numero { get; set; }
        public string? Significado { get; set; }         
        public string? Elemento { get; set; }
        public string? Arcano { get; set; }
        public string? Vicios { get; set; }
        public string? Virtudes { get; set; }
        public string? Confirmacao  { get; set; }

        // public string ImageUrl { get; set; }
    }
}