namespace G1WEB.Models
{
    public class Produit
    {
        int id;
        string designation;
        double prix;
        int quantite;
        string description;
        string image;

        Categorie categorie;
        public int Id { get => id; set => id = value; }
        public string Designation { get => designation; set => designation = value; }
        public double Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }

        public Categorie Categorie { get => categorie; set => categorie = value; }
    }
}
