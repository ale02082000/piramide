

namespace Piramide
{
    public static class Piramide
    {


        public static int Piani(int mattoni)
        {


            if (mattoni < 1) return 0; // non è possibile costruire la piramide
            int piani = 1;
            int mattonirimanenti = mattoni;
            while (mattonirimanenti >= (2 * piani + 1) * (2 * piani + 1) - 2 * piani)
           
            {
                mattonirimanenti -= (2 * piani + 1) * (2 * piani + 1) - 2 * piani;
                piani++;
           
           
            }
            return piani;
        }



        public static int Rimanenti(int mattoni)
        {


            int piani = Piani(mattoni);
            int mattoni_necessari = (2 * piani - 1) * (2 * piani - 1);
         return mattoni - mattoni_necessari;


        }



    }
}