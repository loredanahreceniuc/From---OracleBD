namespace Proiect_BD
{
    partial class Form4
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
            this.dataGridJucatori = new System.Windows.Forms.DataGridView();
            this.textJucatorTanar = new System.Windows.Forms.TextBox();
            this.buttonJucatorTanar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJucatori)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridJucatori
            // 
            this.dataGridJucatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJucatori.Location = new System.Drawing.Point(27, 23);
            this.dataGridJucatori.Name = "dataGridJucatori";
            this.dataGridJucatori.RowHeadersWidth = 51;
            this.dataGridJucatori.RowTemplate.Height = 24;
            this.dataGridJucatori.Size = new System.Drawing.Size(590, 162);
            this.dataGridJucatori.TabIndex = 1;
            // 
            // textJucatorTanar
            // 
            this.textJucatorTanar.Location = new System.Drawing.Point(27, 222);
            this.textJucatorTanar.Name = "textJucatorTanar";
            this.textJucatorTanar.Size = new System.Drawing.Size(234, 22);
            this.textJucatorTanar.TabIndex = 2;
            // 
            // buttonJucatorTanar
            // 
            this.buttonJucatorTanar.Location = new System.Drawing.Point(316, 222);
            this.buttonJucatorTanar.Name = "buttonJucatorTanar";
            this.buttonJucatorTanar.Size = new System.Drawing.Size(167, 23);
            this.buttonJucatorTanar.TabIndex = 3;
            this.buttonJucatorTanar.Text = "Cel mai tanar jucator";
            this.buttonJucatorTanar.UseVisualStyleBackColor = true;
            this.buttonJucatorTanar.Click += new System.EventHandler(this.buttonJucatorTanar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonJucatorTanar);
            this.Controls.Add(this.textJucatorTanar);
            this.Controls.Add(this.dataGridJucatori);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJucatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridJucatori;
        private System.Windows.Forms.TextBox textJucatorTanar;
        private System.Windows.Forms.Button buttonJucatorTanar;
    }
}