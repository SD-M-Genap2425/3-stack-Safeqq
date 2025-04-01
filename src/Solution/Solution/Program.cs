using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        var historyManager = new HistoryManager();
        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("example.com");
        historyManager.KunjungiHalaman("stackoverflow.com");
        Console.WriteLine("Halaman saat ini: " + historyManager.LihatHalamanSaatIni());
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        Console.WriteLine("Halaman saat ini: " + historyManager.Kembali());
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        Console.WriteLine("Halaman saat ini: " + historyManager.Kembali()); 
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        Console.WriteLine(historyManager.Kembali());  
        historyManager.TampilkanHistory();


        var bracketValidator = new BracketValidator();
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";
        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiInvalid)}");

        string palindromeInput = "Kasur ini rusak";
        string nonPalindromeInput = "Ibu Ratna antar ubi";
        string mixedPalindrome = "Hello World";
        Console.WriteLine($"Apakah '{palindromeInput}' adalah palindrom? {PalindromeChecker.CekPalindrom(palindromeInput)}");
        Console.WriteLine($"Apakah '{nonPalindromeInput}' adalah palindrom? {PalindromeChecker.CekPalindrom(nonPalindromeInput)}");
        Console.WriteLine($"Apakah '{mixedPalindrome}' adalah palindrom? {PalindromeChecker.CekPalindrom(mixedPalindrome)}");

    }
}
