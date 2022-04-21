using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace Calculadora.ViewsModel
{
    public class CalculadoraViewsModel : BindableBase
    {
        public CalculadoraViewsModel()
        {
            SomaCommand = new DelegateCommand(Soma);
            SubtracaoCommand = new DelegateCommand(Subtracao);
            MultiplicacaoCommand = new DelegateCommand(Multiplicacao);
            DivisaoCommand = new DelegateCommand(Divisao);
        }
        
        public int Num1 { get; set; }
        
        public int Num2 { get; set; }

        public int Resultado { get; set; }

        public DelegateCommand SomaCommand { get; set; }

        public DelegateCommand SubtracaoCommand { get; set; }

        public DelegateCommand MultiplicacaoCommand { get; set; }

        public DelegateCommand DivisaoCommand { get; set; }

        public void Soma()
        {
            Resultado = Num1 + Num2;
        }

        public void Subtracao()
        {
            Resultado = Num1 - Num2;
        }

        public void Multiplicacao()
        {
            Resultado = Num1 * Num2;
        }

        public void Divisao()
        {
            Resultado = Num1 / Num2;
        }

    }
}
