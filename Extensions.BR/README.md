Este pacote tem como objetivo promover extensões para estruturas e classes nativos do c#, visando atender necessidades da língua portuguesa e da cultura do Brasil

This package aims to promote extensions to native C # structures and classes to meet the needs of the Portuguese language and Brazilian culture.

```xml
<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Extensions.BR</name>
    </assembly>
    <members>
        <member name="T:Extensions.BR.DateTimeExtension">
            <summary>
            Grupo de métodos de extensão para DateTime
            </summary>
        </member>
        <member name="M:Extensions.BR.DateTimeExtension.ConverterTimeZoneBrasilia(System.DateTime)">
            <summary>
            Converte DateTime para time zone de brasilia
            </summary>
        </member>
        <member name="T:Extensions.BR.DecimalExtensions">
            <summary>
            Grupo de métodos de extensão para Decimal
            </summary>
        </member>
        <member name="M:Extensions.BR.DecimalExtensions.ValorMonetario(System.Decimal)">
            <summary>
            Converte um valor decimal para uma string R$ 9.999,99
            </summary>
        </member>
        <member name="T:Extensions.BR.StringExtensions">
            <summary>
            Grupo de métodos de extensão para DateTime
            </summary>
        </member>
        <member name="M:Extensions.BR.StringExtensions.RemoverAcentos(System.String)">
            <summary>
            Retorna a string sem acentos
            </summary>
        </member>
        <member name="M:Extensions.BR.StringExtensions.ConverterMoedaParaDecimal(System.String)">
            <summary>
            Recebe uma string representando um valor em reais no formato R$ 9.999,99 e retorna o valor decimal
            </summary>
            <param name="text">String text</param>
            <returns>decimal</returns>
        </member>
        <member name="M:Extensions.BR.StringExtensions.CpFValido(System.String)">
            <summary>
            Verifica se a string é um cpf válido.
            </summary>
            <param name="cpf"></param>
            <returns></returns>
        </member>
        <member name="M:Extensions.BR.StringExtensions.CapitalizarFrase(System.String,System.String[],System.String[])">
            <summary>
            Executa o método Extensions.MV.CapitalizeSentence, incluindo as preposições do português como palavras em caixa baixa
            </summary>
        </member>
        <member name="T:Extensions.BR.TimeSpanExtension">
            <summary>
            Grupo de métodos de extensão para TimeSpan
            </summary>
        </member>
        <member name="M:Extensions.BR.TimeSpanExtension.TextoCurto(System.TimeSpan,System.String)">
            <summary>
            Retorna um periodo de tempo em formato de texto curto
            <para/>
            Se for um periodo de tempo for menor que uma hora, retornar 'Recente' ou texto passado por parâmetro
            <para/>
            Se for um periodo menor que um dia, retornar número de horas como 'X H', sendo X o número de horas
            <para/>
            Se for um periodo maior que um dia, retornar número de dias como 'X D', sendo X o número de dias
            <para/>
            Se for um periodo maior que 7 dias, retornar número de semanas como 'X S', sendo X o número de semanas
            </summary>
        </member>
    </members>
</doc>

```
