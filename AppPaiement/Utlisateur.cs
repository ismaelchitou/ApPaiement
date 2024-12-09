using AppPaiements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Utlisateur
    {
        public string Nom { get; set; }
        public List<Paiement> paiements { get; set; }
        public Utlisateur(string nom)
        {
            Nom = nom;
            paiements = new List<Paiement>();
        }
        public void AjouterPaiement(Paiement paiement)
        {
            paiements.Add(paiement);
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Votre Nom est: {Nom}");
            Console.WriteLine("Liste de paiement:");
            foreach (var paiement in paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}
