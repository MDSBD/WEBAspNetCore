namespace G1WEB.Models
{
    public class Categorie
    {
        int id;
        string nom;
        string description;
        string image;

        List<Produit> produits;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }

    }
}
