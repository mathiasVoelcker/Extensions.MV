using System;

namespace Extensions.BR
{
    ///<summary>
    ///Grupo de métodos de extensão para TimeSpan
    ///</summary>
    public static class TimeSpanExtension
    {
        ///<summary>
        ///Retorna um periodo de tempo em formato de texto curto
        ///<para/>
        ///Se for um periodo de tempo for menor que uma hora, retornar 'Recente' ou texto passado por parâmetro
        ///<para/>
        ///Se for um periodo menor que um dia, retornar número de horas como 'X H', sendo X o número de horas
        ///<para/>
        ///Se for um periodo maior que um dia, retornar número de dias como 'X D', sendo X o número de dias
        ///<para/>
        ///Se for um periodo maior que 7 dias, retornar número de semanas como 'X S', sendo X o número de semanas
        ///</summary>
        public static string TextoCurto(this TimeSpan time, string textoRecente = null) {
            var days = time.Days;
            if (days < 1) {
                var hours = time.Hours;
                if (hours < 1)
                    return textoRecente ?? "Recente";
                return string.Format("{0}h", hours);
            }
            if (days >= 7)
                return string.Format("{0} Sem", days / 7);
            return string.Format("{0} D", days);
        }
    }
}