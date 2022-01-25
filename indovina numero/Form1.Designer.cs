namespace indovina_numero
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlla = new System.Windows.Forms.Button();
            this.textInserisciNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlla
            // 
            this.controlla.Location = new System.Drawing.Point(327, 246);
            this.controlla.Name = "controlla";
            this.controlla.Size = new System.Drawing.Size(110, 61);
            this.controlla.TabIndex = 0;
            this.controlla.Text = "controlla";
            this.controlla.UseVisualStyleBackColor = true;
            this.controlla.Click += new System.EventHandler(this.controllaNumero);
            // 
            // textInserisciNumero
            // 
            this.textInserisciNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInserisciNumero.Location = new System.Drawing.Point(233, 173);
            this.textInserisciNumero.Name = "textInserisciNumero";
            this.textInserisciNumero.Size = new System.Drawing.Size(318, 31);
            this.textInserisciNumero.TabIndex = 1;
            this.textInserisciNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "sto pensando a un numero tra:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "numero tentativi:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInserisciNumero);
            this.Controls.Add(this.controlla);
            this.Name = "Form1";
            this.Text = "indovina numero";
            this.Load += new System.EventHandler(this.controllaNumero);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlla;
        private System.Windows.Forms.TextBox textInserisciNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

