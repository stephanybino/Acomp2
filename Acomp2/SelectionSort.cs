namespace Acomp2
{
    class SelectionSort : ISort
    {
        public void Sort(int[] E, int n)
        {
            for (int i = 0; i<n; i++) 
            {
                int k = i;
                int x = E[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (E[j] < x)
                    {
                        k = j;
                        x = E[k];
                    }
                }
                E[k] = E[i];
                E[i] = x;
            }

  // throw new System.NotImplementedException();
        }
    }
}
