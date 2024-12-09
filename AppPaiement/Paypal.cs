using AppPaiements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Paypal :Paiement
    {
        public string Courriel { get; set; }
        
        public Paypal(double montant, string desc,string courriel):
            base(montant,desc)
        {
            Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"le infos du Paypal Montan:{Montant},Description{Description},Courriel{Courriel}");
        }
    }
}
