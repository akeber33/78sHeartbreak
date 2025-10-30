using System.Collections.Generic;
using System.Linq;
using _78sHeartbreak.Models;

namespace _78sHeartbreak.Data
{
    public static class TarotSetup
    {
        public static void Popular(AppDbContext context)
        {
            if (!context.TarotCartas.Any())
            {
                var cartas = new List<TarotCartas>
                {
                    new TarotCartas {Nome = "O Mago", Numero = 1, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Interesse, efusividade e superficialidade", Virtudes = "Criatividade, empenho e força de vontade", Confirmacao = "Sim" },
                    new TarotCartas {Nome = "A Sacerdotisa", Numero = 2, Arcano = "Arcano Maior", Elemento = "Água", Significado = "", Vicios = "Ressentimento, passividade e inconformismo", Virtudes = "Reflexão, intuição e dedicação", Confirmacao = "Talvez"},
                    new TarotCartas {Nome = "A Imperatriz", Numero = 3, Arcano = "Arcano Maior", Elemento = "Terra", Significado = "", Vicios = "Fitulidade, luxúria e egocentrismo", Virtudes = "Generosidade, polidez e proteção", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Imperador", Numero = 4, Arcano = "Arcano Maior", Elemento = "Fogo", Significado = "", Vicios = "Irredutibilidade, autoritarismo e frieza", Virtudes = "Objetividade, coragem e liderança", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Papa", Numero = 5, Arcano = "Arcano Maior", Elemento = "Fogo", Significado = "", Vicios = "Pretensão, moralismo e petulância", Virtudes = "Bondade, disposição e conhecimento", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "Os Enamorados", Numero = 6, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Dúvida, ansiedade e indecisão", Virtudes = "Beleza, afeição e delicadeza", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Carro", Numero = 7, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Inconsequência, pressa e fugacidade", Virtudes = "Capacidade, direcionamento e determinação", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "A Justiça", Numero = 8, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Indiferença, distanciamento e dureza", Virtudes = "Ordem, disciplina e decisão", Confirmacao = "Talvez"},
                    new TarotCartas {Nome = "O Eremita", Numero = 9, Arcano = "Arcano Maior", Elemento = "Terra", Significado = "", Vicios = "Reclusão, criticismo e isolamento", Virtudes = "Experiência, compreensão e sabedoria", Confirmacao = "Talvez"},
                    new TarotCartas {Nome = "A Roda da Fortuna", Numero = 10, Arcano = "Arcano Maior", Elemento = "Fogo, água, Terra, Ar", Significado = "", Vicios = "Dispersão, incerteza e desordem", Virtudes = "Dinamismo, ânimo e motivação", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "A Força", Numero = 11, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Teimosia, insistência e descontrole", Virtudes = "Desenvoltura, sagacidade e persuasão", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Enforcado", Numero = 12, Arcano = "Arcano Maior", Elemento = "Água", Significado = "", Vicios = "Vitimismo, ignorância e pessimismo", Virtudes = "Resignação, desprendimento e autossacrifício", Confirmacao = "Talvez"},
                    new TarotCartas {Nome = "A Morte", Numero = 13, Arcano = "Arcano Maior", Elemento = "Terra", Significado = "", Vicios = "Egoísmo, desilusão e negativismo", Virtudes = "Transitoriedade, desapego e consciência", Confirmacao = "Não"},
                    new TarotCartas {Nome = "A temperança", Numero = 14, Arcano = "Arcano Maior", Elemento = "Água", Significado = "", Vicios = "Tédio, lentidão e comodismo", Virtudes = "Tranquilidade, ponderação e paciência", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Diabo", Numero = 15, Arcano = "Arcano Maior", Elemento = "Terra", Significado = "", Vicios = "Perversidade, dependência e inveja", Virtudes = "Instinto, ousadia e controle", Confirmacao = "Não"},
                    new TarotCartas {Nome = "A Torre", Numero = 16, Arcano = "Arcano Maior", Elemento = "Fogo", Significado = "", Vicios = "Desespero, incompreensão e desequilíbrio", Virtudes = "Aceitação, esforço e improviso", Confirmacao = "Não"},
                    new TarotCartas {Nome = "A Estrela", Numero = 17, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Petulância, estrelismo e intransigência", Virtudes = "Confiança, autossuficiência e compreensão", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "A Lua", Numero = 18, Arcano = "Arcano Maior", Elemento = "Água", Significado = "", Vicios = "Pessimismo, pavor e perfídia", Virtudes = "Imaginação, intuição e fascínio", Confirmacao = "Talvez"},
                    new TarotCartas {Nome = "O Sol", Numero = 19, Arcano = "Arcano Maior", Elemento = "Fogo", Significado = "", Vicios = "Egocentrismo, irredutibilidade e pretensão", Virtudes = "Lucidez, alegria e consciência", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Julgamento", Numero = 20, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Ansiedade, pressa e descontentamento", Virtudes = "Abertura, desprendimento e anseio", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Mundo", Numero = 20, Arcano = "Arcano Maior", Elemento = "Terra", Significado = "", Vicios = "Indiferença, egoísmo e obstinação", Virtudes = "Excelência, amizade e equilíbrio", Confirmacao = "Sim"},
                    new TarotCartas {Nome = "O Louco", Numero = 0, Arcano = "Arcano Maior", Elemento = "Ar", Significado = "", Vicios = "Imaturidade, desorganização e irresponsabilidade", Virtudes = "Liberdade, pertencimento e entusiasmo", Confirmacao = "Sim"},
                };

                context.TarotCartas.AddRange(cartas);
                context.SaveChanges();
            }
        }
    }
}
