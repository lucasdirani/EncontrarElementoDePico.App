namespace EncontrarElementoDePico.App.Algoritmos
{
    public static class AlgoritmoElementoPico
    {
        public static int EncontrarElementoDePicoEmComplexidadeLinearDeTempo(int[] arr, int n)
        {
            if (arr[0] > arr[1]) return 0;
            if (arr[n - 1] > arr[n - 2]) return n - 1;
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int EncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo(int[] arr, int n)
        {
            int esquerda = 0;
            int direita = n - 1;
            int metade;
            while (esquerda <= direita)
            {
                metade = (esquerda + direita) >> 1;
                if ((metade == 0 || arr[metade - 1] <= arr[metade])
                    && (metade == n - 1 || arr[metade + 1] <= arr[metade]))
                {
                    return metade;
                }
                else if (metade > 0 && arr[metade - 1] > arr[metade])
                {
                    direita = metade - 1;
                }
                else
                {
                    esquerda = metade + 1;
                }
            }
            return -1;
        }
    }
}