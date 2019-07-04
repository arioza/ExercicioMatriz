using System;
namespace Exerciciomatriz02
{
    public class PosicoesMatriz
    {
        
        public int right(int j)
        {            
            return j+1;
        }

        public int left(int j)
        {
            return j-1;
        }

        public int up(int i)
        {
            return i-1;
        }

        public int down(int i)
        {
            return i+1;
        }
    }
}
