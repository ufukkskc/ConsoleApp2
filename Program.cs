using System;

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism kullanarak bir Employee nesnesi IQuitable tipinde oluşturuluyor
        IQuitable quitter = new Employee { FirstName = "Ufuk", LastName = "Kasikci" };

        // Quit() metodu çağrılıyor
        quitter.Quit();
    }
}