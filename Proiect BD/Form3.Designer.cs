namespace Proiect_BD
{
    partial class Form3
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
            this.dataGridClasament = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonForm1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnCelMaiMicGolaveraj = new System.Windows.Forms.Button();
            this.textEchipaGolaveraj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClasament
            // 
            this.dataGridClasament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasament.Location = new System.Drawing.Point(12, 27);
            this.dataGridClasament.Name = "dataGridClasament";
            this.dataGridClasament.RowHeadersWidth = 51;
            this.dataGridClasament.RowTemplate.Height = 24;
            this.dataGridClasament.Size = new System.Drawing.Size(636, 176);
            this.dataGridClasament.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buttonForm1
            // 
            this.buttonForm1.Location = new System.Drawing.Point(713, 393);
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Size = new System.Drawing.Size(75, 23);
            this.buttonForm1.TabIndex = 1;
            this.buttonForm1.Text = "Back";
            this.buttonForm1.UseVisualStyleBackColor = true;
            this.buttonForm1.Click += new System.EventHandler(this.buttonForm1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // bttnCelMaiMicGolaveraj
            // 
            this.bttnCelMaiMicGolaveraj.Location = new System.Drawing.Point(208, 244);
            this.bttnCelMaiMicGolaveraj.Name = "bttnCelMaiMicGolaveraj";
            this.bttnCelMaiMicGolaveraj.Size = new System.Drawing.Size(221, 29);
            this.bttnCelMaiMicGolaveraj.TabIndex = 4;
            this.bttnCelMaiMicGolaveraj.Text = "Echipa cu cel mai mic golaveraj";
            this.bttnCelMaiMicGolaveraj.UseVisualStyleBackColor = true;
            this.bttnCelMaiMicGolaveraj.Click += new System.EventHandler(this.bttnCelMaiMicGolaveraj_Click);
            // 
            // textEchipaGolaveraj
            // 
            this.textEchipaGolaveraj.Location = new System.Drawing.Point(13, 244);
            this.textEchipaGolaveraj.Multiline = true;
            this.textEchipaGolaveraj.Name = "textEchipaGolaveraj";
            this.textEchipaGolaveraj.Size = new System.Drawing.Size(169, 29);
            this.textEchipaGolaveraj.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEchipaGolaveraj);
            this.Controls.Add(this.bttnCelMaiMicGolaveraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonForm1);
            this.Controls.Add(this.dataGridClasament);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClasament;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonForm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnCelMaiMicGolaveraj;
        private System.Windows.Forms.TextBox textEchipaGolaveraj;
    }
}