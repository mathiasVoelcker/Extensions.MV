using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.BR
{

    ///<summary>
    ///Grupo de métodos de extensão para Decimal
    ///</summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Converte um valor decimal para uma string R$ 9.999,99
        /// </summary>
        public static string ValorMonetario(this decimal valor)
        {
            string valorFormatado = "";
            if (valor < 0) 
                valorFormatado = string.Format("(R$ {0:#,0.00})", valor * -1);
            else
                valorFormatado = string.Format("R$ {0:#,0.00}", valor);
            return valorFormatado;
        }
    }
}
