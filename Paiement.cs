﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public  abstract  class Paiement
    {
        public  Double Montant { get; set; }
        public String Description { get;set; }

        public  Paiement (Double montant, string description) {

            Montant = montant;
            Description = description;
            
        }

        public virtual void afficheDetail()
        {
            Console.WriteLine($"le montant est : {Montant}, la description : {Description}");
        }
            
    }
}
