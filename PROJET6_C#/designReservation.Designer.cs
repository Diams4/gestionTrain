namespace PROJET6_C_
{
    partial class designReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboPaiement = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtNom = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tableReservation = new DataGridView();
            idReserve = new DataGridViewTextBoxColumn();
            nomVoyageur = new DataGridViewTextBoxColumn();
            cin = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            voyage = new DataGridViewTextBoxColumn();
            nbrPlace = new DataGridViewTextBoxColumn();
            paiement = new DataGridViewTextBoxColumn();
            reste = new DataGridViewTextBoxColumn();
            netApayer = new DataGridViewTextBoxColumn();
            txtCin = new NumericUpDown();
            txtNbr = new NumericUpDown();
            comboVoyage = new ComboBox();
            txtPhone = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableReservation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNbr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(comboVoyage);
            panel1.Controls.Add(txtNbr);
            panel1.Controls.Add(txtCin);
            panel1.Controls.Add(comboPaiement);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnModifier);
            panel1.Controls.Add(btnAjouter);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 398);
            panel1.TabIndex = 0;
            // 
            // comboPaiement
            // 
            comboPaiement.FormattingEnabled = true;
            comboPaiement.Location = new Point(678, 78);
            comboPaiement.Name = "comboPaiement";
            comboPaiement.Size = new Size(121, 23);
            comboPaiement.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(500, 81);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 17;
            label7.Text = "Paiement ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 278);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 15;
            label2.Text = "Voyage";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(579, 326);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(132, 48);
            btnSupprimer.TabIndex = 14;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.Location = new Point(727, 250);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(118, 48);
            btnModifier.TabIndex = 13;
            btnModifier.Text = "MODIFIER";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.Location = new Point(479, 250);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(118, 48);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 226);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 10;
            label6.Text = "Numero telephone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(487, 29);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 8;
            label5.Text = "Nombre de place ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 164);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "CIN";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(193, 104);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 107);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 4;
            label3.Text = "Nom du voyageur";
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Id reservation";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableReservation
            // 
            tableReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableReservation.Columns.AddRange(new DataGridViewColumn[] { idReserve, nomVoyageur, cin, phone, voyage, nbrPlace, paiement, reste, netApayer });
            tableReservation.Location = new Point(106, 477);
            tableReservation.Name = "tableReservation";
            tableReservation.RowTemplate.Height = 25;
            tableReservation.Size = new Size(949, 150);
            tableReservation.TabIndex = 2;
            tableReservation.CellClick += tableReservation_CellClick;
            // 
            // idReserve
            // 
            idReserve.HeaderText = "ID";
            idReserve.Name = "idReserve";
            // 
            // nomVoyageur
            // 
            nomVoyageur.HeaderText = "NOM DE VOYAGEUR";
            nomVoyageur.Name = "nomVoyageur";
            // 
            // cin
            // 
            cin.HeaderText = "CIN";
            cin.Name = "cin";
            // 
            // phone
            // 
            phone.HeaderText = "TELEPHONE";
            phone.Name = "phone";
            // 
            // voyage
            // 
            voyage.HeaderText = "VOYAGE";
            voyage.Name = "voyage";
            // 
            // nbrPlace
            // 
            nbrPlace.HeaderText = "NOMBRE DE PLACE RESERVE";
            nbrPlace.Name = "nbrPlace";
            // 
            // paiement
            // 
            paiement.HeaderText = "PAIEMENT";
            paiement.Name = "paiement";
            // 
            // reste
            // 
            reste.HeaderText = "RESTE";
            reste.Name = "reste";
            // 
            // netApayer
            // 
            netApayer.HeaderText = "NET A PAYER";
            netApayer.Name = "netApayer";
            // 
            // txtCin
            // 
            txtCin.Location = new Point(185, 166);
            txtCin.Name = "txtCin";
            txtCin.Size = new Size(120, 23);
            txtCin.TabIndex = 19;
            // 
            // txtNbr
            // 
            txtNbr.Location = new Point(679, 26);
            txtNbr.Name = "txtNbr";
            txtNbr.Size = new Size(120, 23);
            txtNbr.TabIndex = 21;
            // 
            // comboVoyage
            // 
            comboVoyage.FormattingEnabled = true;
            comboVoyage.Location = new Point(184, 279);
            comboVoyage.Name = "comboVoyage";
            comboVoyage.Size = new Size(121, 23);
            comboVoyage.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(219, 223);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(120, 23);
            txtPhone.TabIndex = 23;
            // 
            // designReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 658);
            Controls.Add(tableReservation);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "designReservation";
            Text = "designReservation";
            Shown += designReservation_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableReservation).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCin).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNbr).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtId;
        private Label label1;
        private Label label4;
        private TextBox txtNom;
        private Label label3;
        private Label label5;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private Label label6;
        private Button button1;
        private DataGridView tableReservation;
        private ComboBox comboPaiement;
        private Label label7;
        private Label label2;
        private DataGridViewTextBoxColumn idReserve;
        private DataGridViewTextBoxColumn nomVoyageur;
        private DataGridViewTextBoxColumn cin;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn voyage;
        private DataGridViewTextBoxColumn nbrPlace;
        private DataGridViewTextBoxColumn paiement;
        private DataGridViewTextBoxColumn reste;
        private DataGridViewTextBoxColumn netApayer;
        private NumericUpDown txtCin;
        private NumericUpDown txtNbr;
        private NumericUpDown txtPhone;
        private ComboBox comboVoyage;
    }
}