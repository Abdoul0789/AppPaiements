using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class PayPal:Paiement
    {
            public string Courriel { get; set; }

            public PayPal(double montant, string description, string email) : base(montant, description)
            {
                Courriel = email;
            }

            public override void afficheDetail()
            {
                Console.WriteLine($"le montant est : {Montant}, la description : {Description},l'email est :{Courriel}");
            }

   
    }
}
