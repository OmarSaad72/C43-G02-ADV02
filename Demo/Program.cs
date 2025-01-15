using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int? SumArrayList(ArrayList arrayList)
        {
            int? Sum = 0;
            if (arrayList is not null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Sum += (int?)arrayList[i];
                }
            }
            return Sum;
        }
        static void Main()
        {
            #region Non Generics Collections{ArrayList}
            ArrayList arrayList = new ArrayList();  // Dynamic Size
            //Console.WriteLine($"Count Of ArrayList: {arrayList.Count}");
            //Console.WriteLine($"Capacity Of ArrayList: {arrayList.Capacity}");
            arrayList.Add(3);
            //Console.WriteLine($"Count Of ArrayList: {arrayList.Count}");
            //Console.WriteLine($"Capacity Of ArrayList: {arrayList.Capacity}");
            arrayList.AddRange(new int[] { 1, 3, 5 });
            //Console.WriteLine($"Count Of ArrayList: {arrayList.Count}");
            //Console.WriteLine($"Capacity Of ArrayList: {arrayList.Capacity}");
            //arrayList.Add(4);
            //Console.WriteLine($"Count Of ArrayList: {arrayList.Count}");
            //Console.WriteLine($"Capacity Of ArrayList: {arrayList.Capacity}"); //double size when added the fifth elemnt
            ArrayList arrayList1 = new ArrayList(5);
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add(6);
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.TrimToSize();
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.Add("Omar");

            int? Sum = SumArrayList(arrayList1);
            //Console.WriteLine(Sum);
            int? sum = SumArrayList(arrayList);
            //Console.WriteLine(sum);
            #endregion

            #region Generics Collections{List}
            //List<int> list = new List<int>();
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list.Add(3);
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list.AddRange(new int[]{ 1,2,4});
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list.Add(3);
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list.TrimExcess();  // New Array Size = 5 & The Old Array ==> UnReachable
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");

            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list.Add(6);
            ////list.Add("Omar");  // Invalid
            //Console.WriteLine($"Count Of List: {list.Count}");
            //Console.WriteLine($"Capacity Of List: {list.Capacity}");
            //list[0] = 8;
            //foreach (var num in list)
            //{
            //    Console.WriteLine(num); 
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine(Helper.SumList(list));
            #endregion

            #region List Methods
            List<int> Numbers = new List<int>(4) { 1, 2, 3, 4 ,3};
            //Numbers.Add(3); //object member method
            //Numbers.AddRange(new int[] { 1, 4 });
            //Numbers.Insert(1, 2);
            //Numbers.InsertRange(4, new int[] { 5, 6 });
            Numbers.Sort();
            //Numbers.Clear();
            foreach (var Num in Numbers)
            {
                Console.WriteLine(Num);
            }
            Console.WriteLine($"Sum List: {Helper.SumList(Numbers)}");
            Console.WriteLine($"Index[2]: {Numbers.BinarySearch(3)}");
            Console.WriteLine($"This Element Is Exist? {Numbers.Contains(9)}");
            Console.WriteLine(Numbers.Capacity);
            Console.WriteLine(Numbers.EnsureCapacity(6));
            Console.WriteLine(Numbers.IndexOf(3));
            Console.WriteLine(Numbers.LastIndexOf(3));
            #endregion
        }
    }
}
