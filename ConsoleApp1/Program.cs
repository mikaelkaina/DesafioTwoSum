class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] resultado = TwoSum(nums, target);

        Console.WriteLine("Índices encontrados: [" + resultado[0] + ", " + resultado[1] + "]");
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mapa = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complemento = target - nums[i];

            if (mapa.ContainsKey(complemento))
            {
                return new int[] { mapa[complemento], i };
            }

            mapa[nums[i]] = i;
        }

        return new int[0]; // Nunca alcançado se sempre existir solução
    }
}
