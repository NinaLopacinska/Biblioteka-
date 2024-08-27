namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Uzytkownicy = new System.Windows.Forms.Button();
            this.Zasoby = new System.Windows.Forms.Button();
            this.BIBLIOTEKA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(102, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Uzytkownicy
            // 
            this.Uzytkownicy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Uzytkownicy.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uzytkownicy.Location = new System.Drawing.Point(102, 328);
            this.Uzytkownicy.Name = "Uzytkownicy";
            this.Uzytkownicy.Size = new System.Drawing.Size(300, 80);
            this.Uzytkownicy.TabIndex = 6;
            this.Uzytkownicy.Text = "Użytkownicy";
            this.Uzytkownicy.UseVisualStyleBackColor = false;
            this.Uzytkownicy.Click += new System.EventHandler(this.Uzytkownicy_Click);
            // 
            // Zasoby
            // 
            this.Zasoby.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Zasoby.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zasoby.Location = new System.Drawing.Point(102, 202);
            this.Zasoby.Name = "Zasoby";
            this.Zasoby.Size = new System.Drawing.Size(300, 80);
            this.Zasoby.TabIndex = 5;
            this.Zasoby.Text = "Zasoby";
            this.Zasoby.UseVisualStyleBackColor = false;
            this.Zasoby.Click += new System.EventHandler(this.Zasoby_Click_1);
            // 
            // BIBLIOTEKA
            // 
            this.BIBLIOTEKA.AutoSize = true;
            this.BIBLIOTEKA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BIBLIOTEKA.Font = new System.Drawing.Font("MingLiU-ExtB", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIBLIOTEKA.Location = new System.Drawing.Point(102, 45);
            this.BIBLIOTEKA.Name = "BIBLIOTEKA";
            this.BIBLIOTEKA.Size = new System.Drawing.Size(465, 83);
            this.BIBLIOTEKA.TabIndex = 4;
            this.BIBLIOTEKA.Text = "BIBLIOTEKA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Forms.Properties.Resources.stan_czytelnictwa_w_polsce2;
            this.ClientSize = new System.Drawing.Size(982, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Uzytkownicy);
            this.Controls.Add(this.Zasoby);
            this.Controls.Add(this.BIBLIOTEKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Uzytkownicy;
        private System.Windows.Forms.Button Zasoby;
        private System.Windows.Forms.Label BIBLIOTEKA;
    }
}

