using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando o Nokia:");
        Smartphone nokia = new Nokia("123456", "Modelo X", "111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando o iPhone:");
        Smartphone iphone = new Iphone("654321", "Modelo Y", "222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
