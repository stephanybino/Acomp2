namespace Acomp2
{
    class InsertionSort : ISort
    {
        public void Sort(int[] E, int n)
        {

            for (int i = 0; i < n; i++)
            {
                int eleito = E[i];
                int j = i - 1;
                while ((j >= 0) && (eleito < E[j]))
                {
                    E[j + 1] = E[j];
                    j = j - 1;
                }
                if (j != i)
                {
                    E[j + 1] = eleito;

                }
            }
        }

                
                  

              //  throw new System.NotImplementedException();
        
    }
}
