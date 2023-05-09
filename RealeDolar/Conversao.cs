namespace RealeDolar
{
    public static class Conversao
    {
        public static float DolarParaReal(float ValorDolar)
        {
            float Dolar = ValorDolar;

            float Real = (Dolar * 5);

            return Real; 
        }

        public static float RealParaDolar(float ValorReal)
        {
            float Real = ValorReal;

            float Dolar = (Real / 5);

            return Dolar;
        }
    }

    
}