namespace PROJET6_C_
{
    partial class designItineraire
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
            label1 = new Label();
            panel1 = new Panel();
            fraisVoyage = new NumericUpDown();
            heureVoyage = new DateTimePicker();
            txtVoyage = new TextBox();
            comboNumTrain = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            label7 = new Label();
            label5 = new Label();
            dateVoyage = new DateTimePicker();
            label4 = new Label();
            txtId = new TextBox();
            tableItineraire = new DataGridView();
            idIt = new DataGridViewTextBoxColumn();
            voyage = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            heure = new DataGridViewTextBoxColumn();
            frais = new DataGridViewTextBoxColumn();
            nbrPlaceDispo = new DataGridViewTextBoxColumn();
            numTrain = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fraisVoyage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableItineraire).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Id itineraire";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(fraisVoyage);
            panel1.Controls.Add(heureVoyage);
            panel1.Controls.Add(txtVoyage);
            panel1.Controls.Add(comboNumTrain);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnModifier);
            panel1.Controls.Add(btnAjouter);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateVoyage);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 595);
            panel1.TabIndex = 1;
            // 
            // fraisVoyage
            // 
            fraisVoyage.Location = new Point(63, 286);
            fraisVoyage.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            fraisVoyage.Name = "fraisVoyage";
            fraisVoyage.Size = new Size(163, 23);
            fraisVoyage.TabIndex = 26;
            // 
            // heureVoyage
            // 
            heureVoyage.Format = DateTimePickerFormat.Time;
            heureVoyage.Location = new Point(31, 225);
            heureVoyage.Name = "heureVoyage";
            heureVoyage.ShowUpDown = true;
            heureVoyage.Size = new Size(195, 23);
            heureVoyage.TabIndex = 25;
            // 
            // txtVoyage
            // 
            txtVoyage.Location = new Point(126, 71);
            txtVoyage.Name = "txtVoyage";
            txtVoyage.Size = new Size(100, 23);
            txtVoyage.TabIndex = 24;
            // 
            // comboNumTrain
            // 
            comboNumTrain.FormattingEnabled = true;
            comboNumTrain.Location = new Point(133, 339);
            comboNumTrain.Name = "comboNumTrain";
            comboNumTrain.Size = new Size(118, 23);
            comboNumTrain.TabIndex = 23;
            comboNumTrain.SelectedIndexChanged += comboNumTrain_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 284);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 19;
            label3.Text = "Frais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 17;
            label2.Text = "Voyage";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(51, 526);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(136, 47);
            btnSupprimer.TabIndex = 16;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.Location = new Point(125, 473);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(126, 47);
            btnModifier.TabIndex = 15;
            btnModifier.Text = "MODIFIER";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.Location = new Point(9, 473);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(110, 47);
            btnAjouter.TabIndex = 14;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 339);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 5;
            label7.Text = "Numero train";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 202);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 9;
            label5.Text = "Heure de depart";
            // 
            // dateVoyage
            // 
            dateVoyage.Location = new Point(31, 158);
            dateVoyage.Name = "dateVoyage";
            dateVoyage.Size = new Size(195, 23);
            dateVoyage.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 124);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 7;
            label4.Text = "Date de voyage";
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.Visible = false;
            // 
            // tableItineraire
            // 
            tableItineraire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableItineraire.Columns.AddRange(new DataGridViewColumn[] { idIt, voyage, date, heure, frais, nbrPlaceDispo, numTrain });
            tableItineraire.Location = new Point(299, 26);
            tableItineraire.Name = "tableItineraire";
            tableItineraire.RowTemplate.Height = 25;
            tableItineraire.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableItineraire.Size = new Size(753, 595);
            tableItineraire.TabIndex = 2;
            tableItineraire.CellClick += tableItineraire_CellClick;
            // 
            // idIt
            // 
            idIt.DataPropertyName = "idIt";
            idIt.HeaderText = "ID";
            idIt.Name = "idIt";
            // 
            // voyage
            // 
            voyage.DataPropertyName = "voyage";
            voyage.HeaderText = "VOYAGE";
            voyage.Name = "voyage";
            // 
            // date
            // 
            date.DataPropertyName = "dateVoyage";
            date.HeaderText = "DATE DE VOYAGE";
            date.Name = "date";
            // 
            // heure
            // 
            heure.DataPropertyName = "heure";
            heure.HeaderText = "HEURE";
            heure.Name = "heure";
            // 
            // frais
            // 
            frais.DataPropertyName = "frais";
            frais.HeaderText = "FRAIS";
            frais.Name = "frais";
            // 
            // nbrPlaceDispo
            // 
            nbrPlaceDispo.DataPropertyName = "nbrPlaceDispo";
            nbrPlaceDispo.HeaderText = "NOMBRE DE PLACE LIBRE";
            nbrPlaceDispo.Name = "nbrPlaceDispo";
            // 
            // numTrain
            // 
            numTrain.DataPropertyName = "idTrain";
            numTrain.HeaderText = "NUMERO TRAIN";
            numTrain.Name = "numTrain";
            // 
            // designItineraire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 644);
            Controls.Add(tableItineraire);
            Controls.Add(panel1);
            Name = "designItineraire";
            Text = "designItineraire";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fraisVoyage).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableItineraire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtId;
        private Label label4;
        private Label label5;
        private DateTimePicker dateVoyage;
        private Button btnAjouter;
        private Label label7;
        private Button btnModifier;
        private Button btnSupprimer;
        private Label label3;
        private Label label2;
        private DataGridView tableItineraire;
        private ComboBox comboNumTrain;
        private TextBox txtVoyage;
        private DateTimePicker heureVoyage;
        private NumericUpDown fraisVoyage;
        private DataGridViewTextBoxColumn idIt;
        private DataGridViewTextBoxColumn voyage;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn heure;
        private DataGridViewTextBoxColumn frais;
        private DataGridViewTextBoxColumn nbrPlaceDispo;
        private DataGridViewTextBoxColumn numTrain;
    }
}