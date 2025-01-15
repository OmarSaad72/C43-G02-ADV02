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
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add(6);
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.TrimToSize();
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.Add("Omar");

            int? Sum = SumArrayList(arrayList1);
            Console.WriteLine(Sum);
            int? sum = SumArrayList(arrayList);
            Console.WriteLine(sum);
            #endregion


        }
    }
}
