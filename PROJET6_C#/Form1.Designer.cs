namespace PROJET6_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnListeRecherche = new Button();
            btnItineraire = new Button();
            btnReservation = new Button();
            btnTrain = new Button();
            btnAccueil = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 59);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(btnListeRecherche);
            panel2.Controls.Add(btnItineraire);
            panel2.Controls.Add(btnReservation);
            panel2.Controls.Add(btnTrain);
            panel2.Controls.Add(btnAccueil);
            panel2.Location = new Point(2, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 70);
            panel2.TabIndex = 1;
            // 
            // btnListeRecherche
            // 
            btnListeRecherche.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListeRecherche.Location = new Point(537, 0);
            btnListeRecherche.Name = "btnListeRecherche";
            btnListeRecherche.Size = new Size(304, 70);
            btnListeRecherche.TabIndex = 4;
            btnListeRecherche.Text = "LISTE DES VOYAGES";
            btnListeRecherche.UseVisualStyleBackColor = true;
            btnListeRecherche.Click += btnListeRecherche_Click;
            // 
            // btnItineraire
            // 
            btnItineraire.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnItineraire.Location = new Point(408, 0);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(132, 70);
            btnItineraire.TabIndex = 3;
            btnItineraire.Text = "ITINERAIRE";
            btnItineraire.UseVisualStyleBackColor = true;
            btnItineraire.Click += btnItineraire_Click;
            // 
            // btnReservation
            // 
            btnReservation.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservation.Location = new Point(257, 0);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(156, 70);
            btnReservation.TabIndex = 2;
            btnReservation.Text = "RESERVATION";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnTrain
            // 
            btnTrain.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrain.Location = new Point(127, 0);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(132, 70);
            btnTrain.TabIndex = 1;
            btnTrain.Text = "TRAIN";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnAccueil
            // 
            btnAccueil.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccueil.Location = new Point(0, 0);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(132, 70);
            btnAccueil.TabIndex = 0;
            btnAccueil.Text = "ACCUEIL";
            btnAccueil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnListeRecherche;
        private Button btnItineraire;
        private Button btnReservation;
        private Button btnTrain;
        private Button btnAccueil;
    }
}