namespace WindowsFormsApp3
{
  partial class Form1
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxChemin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contenuFichier = new System.Windows.Forms.TextBox();
            this.labelNomBDD = new System.Windows.Forms.Label();
            this.labelLoginBDD = new System.Windows.Forms.Label();
            this.boutonVerifBDD = new System.Windows.Forms.Button();
            this.passBDD = new System.Windows.Forms.MaskedTextBox();
            this.labelPassBDD = new System.Windows.Forms.Label();
            this.loginBDD = new System.Windows.Forms.TextBox();
            this.nomBDD = new System.Windows.Forms.TextBox();
            this.textboxIPMysql = new System.Windows.Forms.TextBox();
            this.labelIBDD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cliquez pour choisir le fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxChemin
            // 
            this.textBoxChemin.Location = new System.Drawing.Point(387, 70);
            this.textBoxChemin.Name = "textBoxChemin";
            this.textBoxChemin.Size = new System.Drawing.Size(210, 20);
            this.textBoxChemin.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "VALIDER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contenuFichier
            // 
            this.contenuFichier.Location = new System.Drawing.Point(893, 70);
            this.contenuFichier.Multiline = true;
            this.contenuFichier.Name = "contenuFichier";
            this.contenuFichier.Size = new System.Drawing.Size(210, 20);
            this.contenuFichier.TabIndex = 3;
            // 
            // labelNomBDD
            // 
            this.labelNomBDD.AutoSize = true;
            this.labelNomBDD.Location = new System.Drawing.Point(226, 177);
            this.labelNomBDD.Name = "labelNomBDD";
            this.labelNomBDD.Size = new System.Drawing.Size(87, 13);
            this.labelNomBDD.TabIndex = 10;
            this.labelNomBDD.Text = "Nom de la base :";
            // 
            // labelLoginBDD
            // 
            this.labelLoginBDD.AutoSize = true;
            this.labelLoginBDD.Location = new System.Drawing.Point(464, 177);
            this.labelLoginBDD.Name = "labelLoginBDD";
            this.labelLoginBDD.Size = new System.Drawing.Size(91, 13);
            this.labelLoginBDD.TabIndex = 11;
            this.labelLoginBDD.Text = "Login de la base :";
            this.labelLoginBDD.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boutonVerifBDD
            // 
            this.boutonVerifBDD.Location = new System.Drawing.Point(1043, 171);
            this.boutonVerifBDD.Name = "boutonVerifBDD";
            this.boutonVerifBDD.Size = new System.Drawing.Size(139, 23);
            this.boutonVerifBDD.TabIndex = 8;
            this.boutonVerifBDD.Text = "Test de la connexion";
            this.boutonVerifBDD.UseVisualStyleBackColor = true;
            // 
            // passBDD
            // 
            this.passBDD.Location = new System.Drawing.Point(881, 173);
            this.passBDD.Name = "passBDD";
            this.passBDD.Size = new System.Drawing.Size(139, 20);
            this.passBDD.TabIndex = 7;
            // 
            // labelPassBDD
            // 
            this.labelPassBDD.AutoSize = true;
            this.labelPassBDD.Location = new System.Drawing.Point(721, 177);
            this.labelPassBDD.Name = "labelPassBDD";
            this.labelPassBDD.Size = new System.Drawing.Size(129, 13);
            this.labelPassBDD.TabIndex = 12;
            this.labelPassBDD.Text = "Mot de passe de la base :";
            // 
            // loginBDD
            // 
            this.loginBDD.Location = new System.Drawing.Point(561, 173);
            this.loginBDD.Name = "loginBDD";
            this.loginBDD.Size = new System.Drawing.Size(139, 20);
            this.loginBDD.TabIndex = 6;
            // 
            // nomBDD
            // 
            this.nomBDD.Location = new System.Drawing.Point(319, 174);
            this.nomBDD.Name = "nomBDD";
            this.nomBDD.Size = new System.Drawing.Size(139, 20);
            this.nomBDD.TabIndex = 5;
            // 
            // textboxIPMysql
            // 
            this.textboxIPMysql.Location = new System.Drawing.Point(87, 173);
            this.textboxIPMysql.Name = "textboxIPMysql";
            this.textboxIPMysql.Size = new System.Drawing.Size(139, 20);
            this.textboxIPMysql.TabIndex = 4;
            // 
            // labelIBDD
            // 
            this.labelIBDD.AutoSize = true;
            this.labelIBDD.Location = new System.Drawing.Point(12, 177);
            this.labelIBDD.Name = "labelIBDD";
            this.labelIBDD.Size = new System.Drawing.Size(74, 13);
            this.labelIBDD.TabIndex = 9;
            this.labelIBDD.Text = "Ip de la base :";
            this.labelIBDD.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 258);
            this.Controls.Add(this.labelPassBDD);
            this.Controls.Add(this.labelLoginBDD);
            this.Controls.Add(this.labelNomBDD);
            this.Controls.Add(this.labelIBDD);
            this.Controls.Add(this.boutonVerifBDD);
            this.Controls.Add(this.passBDD);
            this.Controls.Add(this.loginBDD);
            this.Controls.Add(this.nomBDD);
            this.Controls.Add(this.textboxIPMysql);
            this.Controls.Add(this.contenuFichier);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxChemin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Choix du fichier";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBoxChemin;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox contenuFichier;
    private System.Windows.Forms.Label labelNomBDD;
    private System.Windows.Forms.Label labelLoginBDD;
    private System.Windows.Forms.Button boutonVerifBDD;
    private System.Windows.Forms.MaskedTextBox passBDD;
    private System.Windows.Forms.Label labelPassBDD;
    private System.Windows.Forms.TextBox loginBDD;
    private System.Windows.Forms.TextBox nomBDD;
    private System.Windows.Forms.TextBox textboxIPMysql;
    private System.Windows.Forms.Label labelIBDD;
  }
}

