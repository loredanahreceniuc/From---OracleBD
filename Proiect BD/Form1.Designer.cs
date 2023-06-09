namespace Proiect_BD
{
    partial class Form1
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
            this.dataGridEchipa = new System.Windows.Forms.DataGridView();
            this.comboEchipe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFormClasament = new System.Windows.Forms.Button();
            this.buttonFormJucatori = new System.Windows.Forms.Button();
            this.btnFormMeciuri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEchipa
            // 
            this.dataGridEchipa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEchipa.Location = new System.Drawing.Point(31, 32);
            this.dataGridEchipa.Name = "dataGridEchipa";
            this.dataGridEchipa.RowHeadersWidth = 51;
            this.dataGridEchipa.RowTemplate.Height = 24;
            this.dataGridEchipa.Size = new System.Drawing.Size(620, 313);
            this.dataGridEchipa.TabIndex = 0;
            // 
            // comboEchipe
            // 
            this.comboEchipe.FormattingEnabled = true;
            this.comboEchipe.Location = new System.Drawing.Point(31, 365);
            this.comboEchipe.Name = "comboEchipe";
            this.comboEchipe.Size = new System.Drawing.Size(121, 24);
            this.comboEchipe.TabIndex = 1;
            this.comboEchipe.SelectedIndexChanged += new System.EventHandler(this.comboEchipe_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Form adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFormClasament
            // 
            this.buttonFormClasament.Location = new System.Drawing.Point(669, 71);
            this.buttonFormClasament.Name = "buttonFormClasament";
            this.buttonFormClasament.Size = new System.Drawing.Size(119, 23);
            this.buttonFormClasament.TabIndex = 3;
            this.buttonFormClasament.Text = "Clasament";
            this.buttonFormClasament.UseVisualStyleBackColor = true;
            this.buttonFormClasament.Click += new System.EventHandler(this.buttonFormClasament_Click);
            // 
            // buttonFormJucatori
            // 
            this.buttonFormJucatori.Location = new System.Drawing.Point(669, 110);
            this.buttonFormJucatori.Name = "buttonFormJucatori";
            this.buttonFormJucatori.Size = new System.Drawing.Size(119, 23);
            this.buttonFormJucatori.TabIndex = 4;
            this.buttonFormJucatori.Text = "Jucatori";
            this.buttonFormJucatori.UseVisualStyleBackColor = true;
            this.buttonFormJucatori.Click += new System.EventHandler(this.buttonFormJucatori_Click);
            // 
            // btnFormMeciuri
            // 
            this.btnFormMeciuri.Location = new System.Drawing.Point(669, 150);
            this.btnFormMeciuri.Name = "btnFormMeciuri";
            this.btnFormMeciuri.Size = new System.Drawing.Size(119, 23);
            this.btnFormMeciuri.TabIndex = 6;
            this.btnFormMeciuri.Text = "Meciuri";
            this.btnFormMeciuri.UseVisualStyleBackColor = true;
            this.btnFormMeciuri.Click += new System.EventHandler(this.btnFormMeciuri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormMeciuri);
            this.Controls.Add(this.buttonFormJucatori);
            this.Controls.Add(this.buttonFormClasament);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboEchipe);
            this.Controls.Add(this.dataGridEchipa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEchipa;
        private System.Windows.Forms.ComboBox comboEchipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFormClasament;
        private System.Windows.Forms.Button buttonFormJucatori;
        private System.Windows.Forms.Button btnFormMeciuri;
    }
}

