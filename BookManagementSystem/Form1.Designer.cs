namespace BookManagementSystem
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
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnCreateGenre = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(27, 29);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 0;
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(39, 55);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(75, 23);
            this.btnCreateGenre.TabIndex = 1;
            this.btnCreateGenre.Text = "button1";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.btnCreateGenre_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(39, 240);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "button1";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(27, 214);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(100, 20);
            this.txtBook.TabIndex = 2;
            // 
            // cmbGenres
            // 
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(12, 187);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(141, 21);
            this.cmbGenres.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.btnCreateBook);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.btnCreateGenre);
            this.Controls.Add(this.txtGenre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnCreateGenre;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox cmbGenres;
    }
}

