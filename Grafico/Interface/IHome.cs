using Grafico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grafico.Interface
{
    interface IHome
    {

        
        Task<List<GraficoViewModel>> RelatorioGeral();
        
    }
}