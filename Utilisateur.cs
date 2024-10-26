using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; } = new List<Paiement>();

        
        public Utilisateur (string nom)
        {
            Nom = nom;
        }

        
        public void afficheInfos()
        {
            Console.WriteLine($"Nom de l'utilisateur : {Nom}");
            Console.WriteLine("Historique des paiements :");
            foreach (var paiement in Paiements)
            {
                paiement.afficheDetail();
            }
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }

    }
}
