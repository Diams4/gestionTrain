namespace PROJET6_C_
{
    partial class designTrain
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
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtNbr = new TextBox();
            label3 = new Label();
            txtDesign = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            tableTrain = new DataGridView();
            idTrain = new DataGridViewTextBoxColumn();
            design = new DataGridViewTextBoxColumn();
            nbrPlace = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableTrain).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnModifier);
            panel1.Controls.Add(btnAjouter);
            panel1.Controls.Add(txtNbr);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDesign);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(64, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 331);
            panel1.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(46, 278);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(124, 42);
            btnSupprimer.TabIndex = 8;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.Location = new Point(114, 230);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(97, 42);
            btnModifier.TabIndex = 7;
            btnModifier.Text = "MODIFIER";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.Location = new Point(15, 230);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(93, 42);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtNbr
            // 
            txtNbr.Location = new Point(30, 186);
            txtNbr.Name = "txtNbr";
            txtNbr.Size = new Size(100, 23);
            txtNbr.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 153);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre de place";
            // 
            // txtDesign
            // 
            txtDesign.Location = new Point(121, 100);
            txtDesign.Name = "txtDesign";
            txtDesign.Size = new Size(100, 23);
            txtDesign.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Design";
            // 
            // txtId
            // 
            txtId.Location = new Point(121, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Id train";
            // 
            // tableTrain
            // 
            tableTrain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableTrain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableTrain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTrain.Columns.AddRange(new DataGridViewColumn[] { idTrain, design, nbrPlace });
            tableTrain.Location = new Point(358, 59);
            tableTrain.Name = "tableTrain";
            tableTrain.RowTemplate.Height = 25;
            tableTrain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableTrain.Size = new Size(414, 326);
            tableTrain.TabIndex = 1;
            tableTrain.CellClick += tableTrain_CellClick;
            // 
            // idTrain
            // 
            idTrain.DataPropertyName = "idTrain";
            idTrain.HeaderText = "ID TRAIN";
            idTrain.Name = "idTrain";
            // 
            // design
            // 
            design.DataPropertyName = "design";
            design.HeaderText = "DESIGN";
            design.Name = "design";
            // 
            // nbrPlace
            // 
            nbrPlace.DataPropertyName = "nbrPlace";
            nbrPlace.HeaderText = "NOMBRE DE PLACE";
            nbrPlace.Name = "nbrPlace";
            // 
            // designTrain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableTrain);
            Controls.Add(panel1);
            Name = "designTrain";
            Text = "designTrain";
            Shown += designTrain_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableTrain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtDesign;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtNbr;
        private DataGridView tableTrain;
        private DataGridViewTextBoxColumn idTrain;
        private DataGridViewTextBoxColumn design;
        private DataGridViewTextBoxColumn nbrPlace;
    }
}