using System.Collections;
using System.Linq;

namespace KolleksiyonOdevi
{
    public class FirstQuestion
    {
        public static ArrayList _primeList = new();
        public static ArrayList _notPrimeList = new();
        public static void Main(string[] arg)
        {
            /*
             Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak
             2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
               
               Negatif ve numeric olmayan girişleri engelleyin.
               Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
             
             
             
             */
            
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    checkpoint:
                    Console.Write($"{i+1}. Sayıyı giriniz: ");
                    var input = Convert.ToInt16(Console.ReadLine());
                    if (!CheckIfValid(input))
                    {
                        i--;
                        goto checkpoint;
                    }

                    if (input == 1)
                    {
                        _notPrimeList.Add(input);
                    }
                    if (input == 2)
                    {
                        _primeList.Add(input);
                    }
                    else
                    {

                        for (var j = 2; j < input; j++)
                        {
                            if (input%j == 0)
                            {
                                _notPrimeList.Add(input);
                                break;
                            }
                        }

                        if (!_notPrimeList.Contains(input))
                        {
                            _primeList.Add(input);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //Second Task
            SecondTask(_primeList,_notPrimeList);
            //Third Task
            ThirdTask();

            Console.Read();
        }

        private static void ThirdTask()
        {
            Console.WriteLine("Asal sayıların eleman sayısı: "+_primeList.Count);
            Console.WriteLine("Asal olmayan sayıların eleman sayısı: "+_notPrimeList.Count);
            Console.WriteLine("********************************");
            var primeListSum = _primeList.Cast<object>().Sum(t => Convert.ToInt32(t!));
            var notPrimeListSum = _notPrimeList.Cast<object>().Sum(t => Convert.ToInt32(t!));
            Console.WriteLine("Asal sayılarının ortalaması : "+primeListSum/_primeList.Count);
            Console.WriteLine("Asal olmayan sayılarının ortalaması : "+notPrimeListSum/_notPrimeList.Count);
        }

        public static void SecondTask(ArrayList primeArrayList, ArrayList notPrimeArrayList)
        {
            Console.WriteLine("Prime Numbers ");
            ListArray(primeArrayList);
            Console.WriteLine();
            Console.WriteLine("Not Prime Numbers");
            ListArray(notPrimeArrayList);
            Console.WriteLine();
        }
        public static void ListArray(ArrayList array)
        {
            array.Sort();
            for (var i = array.Count-1; i >= 0; i--)
            {
                Console.Write(array[i]+" ");
            }
        }
        public static bool CheckIfValid(int number)
        {
            return number >= 0;
        }
    }
}