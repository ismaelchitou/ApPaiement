using AppPaiement;

namespace AppPaiements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarteCredit achat1 = new CarteCredit(150.00, "dollarama", 567891234);
            CarteCredit achat2 = new CarteCredit(7.50, "Magasin", 546382920);
            CarteCredit achat3 = new CarteCredit(39.45, "Telephone", 363287423);

            Paypal transaction1 = new Paypal(150.00, "frais de scolarte", "akwame@gmail.com");
            Paypal transaction2 = new Paypal(2000, "Achat voiture", "chitouismael@gmail.com");
        }
    }
}