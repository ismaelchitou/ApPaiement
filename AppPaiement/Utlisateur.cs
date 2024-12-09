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
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Utilisateur: {Nom}");
            Console.WriteLine("Liste des paiements:");
        }
    }
}
