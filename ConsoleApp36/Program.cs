namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = { 1, 2, 4 };
            List<int> numberlist = new List<int>()
            {
                1,2,3,4
            };
            numberlist.Add(1);
           
            numberlist.AddRange(numbers);
            numberlist.AddRange(GetNumbers());
            numberlist.Remove(1);
            numberlist.RemoveAt(4);
            numberlist.Insert(0, 6);
            numberlist.Clear();
            var listcount = numberlist.Count;
            numberlist.RemoveAll(p => p == 1);// lyambda
            Console.WriteLine(numberlist.Capacity);
            Console.WriteLine(numberlist.Count);
            foreach(var item in numberlist)
            {
                Console.Write(item);
            }
        }

        static IEnumerable<int> GetNumbers()
        {
            var items = Enumerable.Range(0, 2000);
          
            foreach(var item in items)
            {
                if(item % 2 ==0)
                {
                    yield return item;
                }
            }
        }
    }
}