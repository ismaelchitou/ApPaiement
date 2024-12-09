using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        public double Montant { get; set; }
        public string Description { get; set; }

        public Paiement(double montant, string desc)
        {
            Montant = montant;
            Description = desc;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Le paiement est : Montant:{Montant},Description:{Description}");
        }
    }
}