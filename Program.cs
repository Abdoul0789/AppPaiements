using AppPaiements;

internal class Program
{
    public static void Main(string[] args)
    {
        CarteCredit a1 = new CarteCredit(100.0, "Achat de ballons", 1234);
        CarteCredit a2 = new CarteCredit(100.0, "Achat de livres", 1234);
        CarteCredit a3 = new CarteCredit(100.0, "Achat de vetemens", 1234);

        a1.afficheDetail();
        a2.afficheDetail();
        a3.afficheDetail();
    }
}