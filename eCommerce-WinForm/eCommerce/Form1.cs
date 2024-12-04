using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace eCommerce
{
    public partial class Form1 : Form
    {
        private int numCrescente = 0; //per generare automaticamente id
        private double totPrezzo = 0;
        Carrello C = new Carrello("1");


        public Form1()
        {
            InitializeComponent();
        }

        private void AggiornaInterfaccia()
        {
            listBoxCarrello.DataSource = null;
            listBoxCarrello.DataSource = C.ProdottiCarrello;
            listBoxCarrello.DisplayMember = "modelloId";
            labelPrice.Text = totPrezzo.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                Prodotto Tesla = new Prodotto("Tesla", "Model 3", numCrescente.ToString(), 40000);
                C.aggiungiProdotto(Tesla);
                numCrescente++;
                Tesla.OttieniModelloId(); //per uniformare listbox
                totPrezzo += Tesla.Prezzo;
                AggiornaInterfaccia();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCarrello.SelectedIndex;

            // Verifica che un elemento sia selezionato
            if (selectedIndex != -1)
            {
                Prodotto prodottoSelezionato = C.ProdottiCarrello[selectedIndex];

                C.rimuoviProdotto(prodottoSelezionato);
                totPrezzo -= prodottoSelezionato.Prezzo;
                AggiornaInterfaccia();
            }
            else
            {
                MessageBox.Show("Seleziona un prodotto da rimuovere cliccandolo dal carrello.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.svuotaCarrello();
            totPrezzo = 0;
            AggiornaInterfaccia();
        }

        private void buttonAddMS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDownMS.Value; i++)
            {
                Prodotto Tesla = new Prodotto("Tesla", "Model S", numCrescente.ToString(), 90000);
                C.aggiungiProdotto(Tesla);
                numCrescente++;
                Tesla.OttieniModelloId(); //per uniformare listbox
                totPrezzo += Tesla.Prezzo;
                AggiornaInterfaccia();
            }
        }

        private void buttonAddMX_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDownMX.Value; i++)
            {
                Prodotto Tesla = new Prodotto("Tesla", "Model X", numCrescente.ToString(), 90000);
                C.aggiungiProdotto(Tesla);
                numCrescente++;
                Tesla.OttieniModelloId(); //per uniformare listbox
                totPrezzo += Tesla.Prezzo;
                AggiornaInterfaccia();
            }
        }

        private void buttonAddRoad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDownRoad.Value; i++)
            {
                Prodotto Tesla = new Prodotto("Tesla", "Roadster", numCrescente.ToString(), 200000);
                C.aggiungiProdotto(Tesla);
                numCrescente++;
                Tesla.OttieniModelloId(); //per uniformare listbox
                totPrezzo += Tesla.Prezzo;
                AggiornaInterfaccia();
            }
        }

        private void Export_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCarrello.Items.Count > 0)
            {
                string json = System.Text.Json.JsonSerializer.Serialize(C.ProdottiCarrello, new JsonSerializerOptions { WriteIndented = true });
                // Scrittura del JSON nel file "carrello.json"
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "carrello.json");
                File.WriteAllText(filePath, json);
                MessageBox.Show("Salvataggio disponibile per l'upload", "Esportazione completata");
            } else
            {
                MessageBox.Show("Selezion almeno un prodotto per esportare", "Carrello vuoto");
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            string filePath = "carrello.json"; // Percorso del file JSON

            // Controlla se il file esiste
            if (File.Exists(filePath))
            {
                C.svuotaCarrello();
                totPrezzo = 0;
                AggiornaInterfaccia();
                try
                {
                    // Leggi il contenuto del file
                    string jsonContent = File.ReadAllText(filePath);

                    // Deserializza il JSON in una lista di oggetti
                    List<Prodotto> prodottiCarrello = JsonConvert.DeserializeObject<List<Prodotto>>(jsonContent);

                    // Aggiungi i prodotti deserializzati a ProdottiCarrello
                    foreach (var prodotto in prodottiCarrello)
                    {
                        C.aggiungiProdotto(prodotto);
                        prodotto.OttieniModelloId();
                        totPrezzo += prodotto.Prezzo;  // Aggiorna il prezzo totale
                        // Aggiorna l'interfaccia con i nuovi dati
                        AggiornaInterfaccia();
                    }
                    MessageBox.Show("Importazione di " + listBoxCarrello.Items.Count + " prodotti completata", "Caricamento terminato");
                    
                }
                //Gestisce le eccezioni dovute al JSON e le visualizza
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel caricare il file JSON: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nessun salvataggio trovato", "Importazione fallita");
            }
        }


    }
}

