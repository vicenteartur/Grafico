using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grafico.Models
{
    public class GraficoViewModel
    {
        public int CodigoComponente { get; set; }
        public string Componente { get; set; }
        public string Modalidade { get; set; }
        public string SubArea { get; set; }
        public string ClassificacaoCriterio { get; set; }
        public int Pontuacao { get; set; }
        public int PontuacaoMaxima { get; set; }
        public int Aprov { get; set; }
    }
}
