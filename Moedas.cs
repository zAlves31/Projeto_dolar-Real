using System;

class ConversorDeMoedas
{
    private static double cotacaoDolar = 5.0; 

    public static void SetCotacaoDolar(double novaCotacao)
    {
        cotacaoDolar = novaCotacao;
    }

    public static double RealParaDolar(double valorEmReais)
    {
        return valorEmReais / cotacaoDolar;
    }

    public static double DolarParaReal(double valorEmDolares)
    {
        return valorEmDolares * cotacaoDolar;
    }
}
