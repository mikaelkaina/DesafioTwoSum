class Program
{
    static void Main()
    {
        int[] nums = { 3, 2, 4 };
        int target = 6;

        int[] resultado = TwoSum(nums, target);

        if (resultado != null && resultado.Length == 2)
        {
            Console.WriteLine("Índices encontrados: [" + resultado[0] + ", " + resultado[1] + "]");
        }
        else
        {
            Console.WriteLine("Nenhuma solução encontrada.");
        }

    }
    static int[]? TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mapa = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complemento = target - nums[i];

            if (mapa.ContainsKey(complemento))
            {
                // Solução encontrada: retorna os índices
                return new int[] { mapa[complemento], i };
            }

            mapa[nums[i]] = i;
        }

        return null;
    }

}  