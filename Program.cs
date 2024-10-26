using AppPaiements;

internal class Program
{
    public static void Main(string[] args)
    {
        CarteCredit a1 = new CarteCredit(100.0, "Achat de ballons", 1234);
        CarteCredit a2 = new CarteCredit(200.0, "Achat de livres", 1234);
        CarteCredit a3 = new CarteCredit(300.0, "Achat de vetemens", 1234);

        a1.afficheDetail();
        a2.afficheDetail();
        a3.afficheDetail();



        PayPal b1 = new PayPal(100.0, "Achat de ballons","abdoul207@gmail.com");
        PayPal b2 = new PayPal(200.0, "Achat de livres", "Azizisow207@gmail.com");
       

        b1.afficheDetail();
        b2.afficheDetail();



        
        Utilisateur utilisateur = new Utilisateur("abdoul aziz sow");

      
        CarteCredit achat1 = new CarteCredit(200.0, "Achat d'ordinateur portable", 4321);
        CarteCredit achat2 = new CarteCredit(30.0, "Achat de café", 8765);
        CarteCredit achat3 = new CarteCredit(120.0, "Achat de vêtements", 6543);

        utilisateur.AjouterPaiement(achat1);
        utilisateur.AjouterPaiement(achat2);
        utilisateur.AjouterPaiement(achat3);

      
        utilisateur.afficheInfos();


    }
}