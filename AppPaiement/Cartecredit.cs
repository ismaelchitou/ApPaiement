using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string desc, int numeroCarte) :
            base(montant, desc)
        {
            NumeroCarte = numeroCarte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Les details du paiements Montan:{Montant},Description:{Description},Numero de carte:{NumeroCarte}");
        }
    }
}