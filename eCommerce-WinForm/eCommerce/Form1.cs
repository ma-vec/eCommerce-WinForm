namespace eCommerce
{
    public partial class Form1 : Form
    {
        private int id = 0; //per generare automaticamente id
        Carrello C = new Carrello("1");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Prodotto Tesla = new Prodotto("Tesla", "Model 3", id, 40000);
            C.aggiungiProdotto(id);
            id++;
        }
    }
}
