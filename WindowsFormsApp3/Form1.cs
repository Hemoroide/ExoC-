using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    OpenFileDialog fileTxt = new OpenFileDialog();
    string pathFile;
    StreamReader fichier = null;
    string codeClient;
    string codeAppli;
    string actif;

    private void button1_Click(object sender, EventArgs e)
    {
      fileTxt.Filter = "TXT|*.txt";

      if (fileTxt.ShowDialog() == DialogResult.OK)
      {
        textBoxChemin.Text = fileTxt.FileName;
        pathFile = fileTxt.FileName;
      }
      
    }
    
    private void button2_Click(object sender, EventArgs e)
    {
      if (File.Exists(pathFile))
      {
        fichier = new StreamReader(pathFile);
        string ligne;
        string fichierTemp = null;
        int nombreLigne = 0;
        string codeClient = null;
        string codeAppli = null;
        string actif = null;
        string regexClient = @"\d{4}";
        string regexAppli = @"\d{3}";
        string regexActif = @"[a-zA-Z]";

        while ((ligne = fichier.ReadLine()) != null)
        {
          nombreLigne++;

          if (nombreLigne <= 1) continue;
            fichierTemp += ligne + '\n';
          // POURQUOI DEVOIR METTRE UN RETOUR A LA LIGNE MANUELLEMENT

        }
               
        string[] valeur = fichierTemp.Split(' ', ';', '\n');

        foreach (var affichageValeur in valeur)
        {
          if (Regex.IsMatch(affichageValeur, regexClient))
          {
            codeClient = affichageValeur;
          }

          if (Regex.IsMatch(affichageValeur, regexAppli))
          {
            codeAppli = affichageValeur;
          }

          if (Regex.IsMatch(affichageValeur, regexActif))
          {
            actif = affichageValeur;
          }

        }

        contenuFichier.Text = codeClient + ' ' + codeAppli + ' ' + actif;
        
        fichier.Close();

        string message = "Le traitement de " + nombreLigne + " lignes est terminé";

        MessageBox.Show(message);

      } else
      {
        contenuFichier.Text = "Le fichier n'existe pas";
      }


    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("ca fonctionne!");
    }

    void boutonVerifBDD_Click(object sender, EventArgs e)
    {
      MessageBox.Show("ca fonctionne!");
    }

  }
}
