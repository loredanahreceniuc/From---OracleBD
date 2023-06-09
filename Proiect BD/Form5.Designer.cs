namespace Proiect_BD
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbEchipa2 = new System.Windows.Forms.ComboBox();
            this.cmbEchipa1 = new System.Windows.Forms.ComboBox();
            this.dataGridEchipa = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbEchipa2
            // 
            this.cmbEchipa2.FormattingEnabled = true;
            this.cmbEchipa2.Location = new System.Drawing.Point(157, 272);
            this.cmbEchipa2.Name = "cmbEchipa2";
            this.cmbEchipa2.Size = new System.Drawing.Size(121, 24);
            this.cmbEchipa2.TabIndex = 1;
            // 
            // cmbEchipa1
            // 
            this.cmbEchipa1.FormattingEnabled = true;
            this.cmbEchipa1.Location = new System.Drawing.Point(12, 272);
            this.cmbEchipa1.Name = "cmbEchipa1";
            this.cmbEchipa1.Size = new System.Drawing.Size(121, 24);
            this.cmbEchipa1.TabIndex = 2;
            // 
            // dataGridEchipa
            // 
            this.dataGridEchipa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEchipa.Location = new System.Drawing.Point(12, 23);
            this.dataGridEchipa.Name = "dataGridEchipa";
            this.dataGridEchipa.RowHeadersWidth = 51;
            this.dataGridEchipa.RowTemplate.Height = 24;
            this.dataGridEchipa.Size = new System.Drawing.Size(478, 197);
            this.dataGridEchipa.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cauta meci";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridEchipa);
            this.Controls.Add(this.cmbEchipa1);
            this.Controls.Add(this.cmbEchipa2);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEchipa2;
        private System.Windows.Forms.ComboBox cmbEchipa1;
        private System.Windows.Forms.DataGridView dataGridEchipa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}