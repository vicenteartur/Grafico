using Grafico.Interface;
using Grafico.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grafico.Services
{
    public class HomeService : IHome
    {

        


        

        public async Task<List<GraficoViewModel>> RelatorioGeral()
        {
            var relatorio = new List<GraficoViewModel>();

            var linha = new GraficoViewModel();

                                       linha.CodigoComponente = 1;
                                       linha.Componente = "Geografia";
                                       linha.SubArea = "Ciencias Humanas";
                                       linha.Modalidade = "Fundamental 2";
                                       linha.Pontuacao = 67;
                                       linha.PontuacaoMaxima = 100;
                                        int calc = Convert.ToInt32(255 - (255 * ((float)linha.Pontuacao / linha.PontuacaoMaxima)));
                                        linha.Aprov = calc;
                                       relatorio.Add(linha);
                        
            linha = new GraficoViewModel();
                        linha.CodigoComponente = 2;
                        linha.Componente = "Historia";
                        linha.SubArea = "Ciencias Humanas";
                        linha.Modalidade = "Fundamental 2";
                        linha.Pontuacao = 85;
                        linha.PontuacaoMaxima = 100;
                        calc = Convert.ToInt32(255 - (255 * ((float)linha.Pontuacao / linha.PontuacaoMaxima)));
                        linha.Aprov = calc;
            relatorio.Add(linha);

            linha = new GraficoViewModel();

            linha.CodigoComponente = 3;
            linha.Componente = "Matemática";
            linha.SubArea = "Matemática e suas Tecnologias";
            linha.Modalidade = "Fundamental 2";
            linha.Pontuacao = 95;
            linha.PontuacaoMaxima = 100;
            calc = Convert.ToInt32(255 - (255 * ((float)linha.Pontuacao / linha.PontuacaoMaxima)));
            linha.Aprov = calc;
            relatorio.Add(linha);

            linha = new GraficoViewModel();

            linha.CodigoComponente = 1;
            linha.Componente = "Lingua Portuguesa";
            linha.SubArea = "Ciencias Humanas";
            linha.Modalidade = "Fundamental 2";
            linha.Pontuacao = 50;
            linha.PontuacaoMaxima = 100;
            calc = Convert.ToInt32(255 - (255 * ((float)linha.Pontuacao / linha.PontuacaoMaxima)));
            linha.Aprov = calc;
            relatorio.Add(linha);

            

            return relatorio;

        }

        
    }
}