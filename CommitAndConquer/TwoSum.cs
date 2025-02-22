
namespace CommitAndConquer
{
    public class TwoSum
    {
        public static int[] Execute_TwoLoops(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var expected = target - numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (expected == numbers[j])
                    {
                        return [i, j];
                    }
                }
            }

            return [0,0];
        }

        public static int[] Execute_OneLoop(int[] numbers, int target)
        {
            var memory = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var expected = target - numbers[i];
                if (memory.ContainsKey(expected))
                {
                    return [memory[expected], i];
                }
                memory.Add(numbers[i], i);
            }

            return [0,0];
        }

        public static int[] abc(int[] numbers, int target)
        {

            return [0, 0];
        }
    }
}
