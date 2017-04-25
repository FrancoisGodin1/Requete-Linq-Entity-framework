namespace Linq
{
    partial class fm_principal
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
            this.cb_requete = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_resultat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_requete
            // 
            this.cb_requete.FormattingEnabled = true;
            this.cb_requete.Location = new System.Drawing.Point(152, 15);
            this.cb_requete.Name = "cb_requete";
            this.cb_requete.Size = new System.Drawing.Size(218, 21);
            this.cb_requete.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(391, 15);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_resultat
            // 
            this.tb_resultat.Location = new System.Drawing.Point(25, 69);
            this.tb_resultat.Name = "tb_resultat";
            this.tb_resultat.Size = new System.Drawing.Size(441, 169);
            this.tb_resultat.TabIndex = 2;
            this.tb_resultat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Requête à executer";
            // 
            // fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_resultat);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cb_requete);
            this.Name = "fm_principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_requete;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RichTextBox tb_resultat;
        private System.Windows.Forms.Label label1;
    }
}

