namespace ThirdQuestion;

public class ThirdQuestion
{
    public static void Main(string[] args)
    {
        var letters = new List<char>()
        {
            'a',
            'e',
            'i',
            'o',
            'ı',
            'ö',
            'ü',
            'u'
        };
        Console.WriteLine("Cümle Giriniz.");
        var phrase = Console.ReadLine()?.ToCharArray().Where(x => letters.Any(y => y == x));
        if (phrase != null)
            foreach (var letter in phrase)
            {
                Console.Write(letter + " ");
            }
    }
}