namespace Forms.Forms
{
    partial class Dodaj_ProduktForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTytul = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxRokWydania = new System.Windows.Forms.TextBox();
            this.textBoxNrKatalogowy = new System.Windows.Forms.TextBox();
            this.textBoxTyp = new System.Windows.Forms.TextBox();
            this.textBoxDodatkowe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj nowy produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj rodzaj produktu";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Książka",
            "Film",
            "Album"});
            this.checkedListBox1.Location = new System.Drawing.Point(15, 133);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(179, 82);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Podaj tytuł ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Podaj autora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Podaj rok wydania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Podaj numer katalogowy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Podaj gatunek produktu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Podaj dodatkowe informacje";
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTytul.Location = new System.Drawing.Point(12, 278);
            this.textBoxTytul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(219, 30);
            this.textBoxTytul.TabIndex = 9;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAutor.Location = new System.Drawing.Point(12, 376);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(219, 30);
            this.textBoxAutor.TabIndex = 10;
            // 
            // textBoxRokWydania
            // 
            this.textBoxRokWydania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRokWydania.Location = new System.Drawing.Point(12, 475);
            this.textBoxRokWydania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRokWydania.Name = "textBoxRokWydania";
            this.textBoxRokWydania.Size = new System.Drawing.Size(219, 30);
            this.textBoxRokWydania.TabIndex = 11;
            // 
            // textBoxNrKatalogowy
            // 
            this.textBoxNrKatalogowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNrKatalogowy.Location = new System.Drawing.Point(12, 572);
            this.textBoxNrKatalogowy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            this.textBoxNrKatalogowy.Size = new System.Drawing.Size(219, 30);
            this.textBoxNrKatalogowy.TabIndex = 12;
            // 
            // textBoxTyp
            // 
            this.textBoxTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTyp.Location = new System.Drawing.Point(292, 280);
            this.textBoxTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTyp.Name = "textBoxTyp";
            this.textBoxTyp.Size = new System.Drawing.Size(219, 30);
            this.textBoxTyp.TabIndex = 13;
            // 
            // textBoxDodatkowe
            // 
            this.textBoxDodatkowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDodatkowe.Location = new System.Drawing.Point(289, 376);
            this.textBoxDodatkowe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDodatkowe.Name = "textBoxDodatkowe";
            this.textBoxDodatkowe.Size = new System.Drawing.Size(219, 30);
            this.textBoxDodatkowe.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("MingLiU-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "ZAPISZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(1, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = " ⭠";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dodaj_ProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Forms.Properties.Resources.stan_czytelnictwa_w_polsce2;
            this.ClientSize = new System.Drawing.Size(982, 640);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDodatkowe);
            this.Controls.Add(this.textBoxTyp);
            this.Controls.Add(this.textBoxNrKatalogowy);
            this.Controls.Add(this.textBoxRokWydania);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTytul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dodaj_ProduktForm";
            this.Text = "Dodaj_produktForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTytul;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxRokWydania;
        private System.Windows.Forms.TextBox textBoxNrKatalogowy;
        private System.Windows.Forms.TextBox textBoxTyp;
        private System.Windows.Forms.TextBox textBoxDodatkowe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}