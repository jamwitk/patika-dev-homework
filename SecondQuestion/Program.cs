public class SecondQuestion
{
    public static int[] Inputs = new int[20];
    public static int[] TheBigger = new int[3];
    public static int[] TheSmallest = new int[3];
    public static void Main(string[] args)
    {

        for (var i = 0; i < 20; i++)
        {
            Console.WriteLine((i+1)+". sayıyı giriniz");
            var input = Convert.ToInt32(Console.ReadLine());
            Inputs[i] = input;
        }

        SecondTask();
        ThirdTask();
    }

    public static void SecondTask()
    {
        
        Array.Reverse(Inputs);
        for (int i = 0; i < TheBigger.Length; i++)
        {
            TheBigger[i] = Inputs[i];
            Console.WriteLine(TheBigger[i]);
        }
        for (int i = 0; i < TheSmallest.Length; i++)
        {
            TheSmallest[i] = Inputs[Inputs.Length-1-i];

        }
    }

    public static void ThirdTask()
    {
        Console.WriteLine($"En Büyük Sayıların eleman sayısı ortalaması {TheBigger.Sum()/3} ");
        Console.WriteLine($"En Küçük Sayıların eleman sayısı ortalaması {TheSmallest.Sum()/3} ");
    }
}