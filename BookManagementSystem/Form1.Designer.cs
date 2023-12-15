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
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(12, 12);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(170, 20);
            this.txtGenre.TabIndex = 0;
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(24, 38);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(134, 23);
            this.btnCreateGenre.TabIndex = 1;
            this.btnCreateGenre.Text = "Create Genre";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.btnCreateGenre_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(39, 227);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "button1";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(27, 201);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(100, 20);
            this.txtBook.TabIndex = 2;
            // 
            // cmbGenres
            // 
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(12, 174);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(141, 21);
            this.cmbGenres.TabIndex = 4;
            // 
            // dgvContent
            // 
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Location = new System.Drawing.Point(414, 201);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(354, 299);
            this.dgvContent.TabIndex = 5;
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(414, 172);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(75, 23);
            this.btnShowBooks.TabIndex = 6;
            this.btnShowBooks.Text = "button1";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(204, 38);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "button2";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.btnCreateBook);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.btnCreateGenre);
            this.Controls.Add(this.txtGenre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnCreateGenre;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddBook;
    }
}

