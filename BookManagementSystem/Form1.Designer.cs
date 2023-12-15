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
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGenerateGenre = new System.Windows.Forms.Button();
            this.btnGenerateAuthors = new System.Windows.Forms.Button();
            this.btnDeleteAllAuthors = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(13, 99);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(134, 20);
            this.txtGenre.TabIndex = 0;
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(12, 125);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(134, 23);
            this.btnCreateGenre.TabIndex = 1;
            this.btnCreateGenre.Text = "Create Genre";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.btnCreateGenre_Click);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToOrderColumns = true;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Location = new System.Drawing.Point(12, 237);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(520, 313);
            this.dgvContent.TabIndex = 5;
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(12, 211);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(135, 20);
            this.btnShowBooks.TabIndex = 6;
            this.btnShowBooks.Text = "Show Books";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(12, 183);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(134, 23);
            this.btnAddAuthor.TabIndex = 8;
            this.btnAddAuthor.Text = "Add an Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 212);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 154);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(134, 23);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Add A Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(425, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 20);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGenerateGenre
            // 
            this.btnGenerateGenre.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateGenre.Name = "btnGenerateGenre";
            this.btnGenerateGenre.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateGenre.TabIndex = 11;
            this.btnGenerateGenre.Text = "Generate Genres";
            this.btnGenerateGenre.UseVisualStyleBackColor = true;
            this.btnGenerateGenre.Click += new System.EventHandler(this.btnGenerateGenre_Click);
            // 
            // btnGenerateAuthors
            // 
            this.btnGenerateAuthors.Location = new System.Drawing.Point(127, 12);
            this.btnGenerateAuthors.Name = "btnGenerateAuthors";
            this.btnGenerateAuthors.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateAuthors.TabIndex = 12;
            this.btnGenerateAuthors.Text = "Generate Authors";
            this.btnGenerateAuthors.UseVisualStyleBackColor = true;
            this.btnGenerateAuthors.Click += new System.EventHandler(this.btnGenerateAuthors_Click);
            // 
            // btnDeleteAllAuthors
            // 
            this.btnDeleteAllAuthors.Location = new System.Drawing.Point(242, 9);
            this.btnDeleteAllAuthors.Name = "btnDeleteAllAuthors";
            this.btnDeleteAllAuthors.Size = new System.Drawing.Size(134, 26);
            this.btnDeleteAllAuthors.TabIndex = 13;
            this.btnDeleteAllAuthors.Text = "Delete All Authors";
            this.btnDeleteAllAuthors.UseVisualStyleBackColor = true;
            this.btnDeleteAllAuthors.Click += new System.EventHandler(this.btnDeleteAllAuthors_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(301, 556);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 28);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 627);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteAllAuthors);
            this.Controls.Add(this.btnGenerateAuthors);
            this.Controls.Add(this.btnGenerateGenre);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.dgvContent);
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
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerateGenre;
        private System.Windows.Forms.Button btnGenerateAuthors;
        private System.Windows.Forms.Button btnDeleteAllAuthors;
        private System.Windows.Forms.Button btnEdit;
    }
}

