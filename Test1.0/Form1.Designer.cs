namespace Test1._0
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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Button btnSearchByAuthor;
        private System.Windows.Forms.Button btnListAllBooks;
        private System.Windows.Forms.ListBox listBoxBooks;

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.btnSearchByAuthor = new System.Windows.Forms.Button();
            this.btnListAllBooks = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(259, 20);
            this.txtId.TabIndex = 0;

            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(259, 20);
            this.txtTitle.TabIndex = 1;

            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(13, 67);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(259, 20);
            this.txtAuthor.TabIndex = 2;

            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(13, 94);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(259, 20);
            this.txtYear.TabIndex = 3;

            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(13, 121);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(259, 20);
            this.txtISBN.TabIndex = 4;

            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(13, 148);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(95, 148);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveBook.TabIndex = 6;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);

            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.Location = new System.Drawing.Point(188, 148);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(84, 23);
            this.btnSearchByTitle.TabIndex = 7;
            this.btnSearchByTitle.Text = "Search by Title";
            this.btnSearchByTitle.UseVisualStyleBackColor = true;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);

            // 
            // btnSearchByAuthor
            // 
            this.btnSearchByAuthor.Location = new System.Drawing.Point(279, 148);
            this.btnSearchByAuthor.Name = "btnSearchByAuthor";
            this.btnSearchByAuthor.Size = new System.Drawing.Size(95, 23);
            this.btnSearchByAuthor.TabIndex = 8;
            this.btnSearchByAuthor.Text = "Search by Author";
            this.btnSearchByAuthor.UseVisualStyleBackColor = true;
            this.btnSearchByAuthor.Click += new System.EventHandler(this.btnSearchByAuthor_Click);

            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.Location = new System.Drawing.Point(381, 148);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(75, 23);
            this.btnListAllBooks.TabIndex = 9;
            this.btnListAllBooks.Text = "List All Books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            this.btnListAllBooks.Click += new System.EventHandler(this.btnListAllBooks_Click);

            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(13, 178);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(443, 147);
            this.listBoxBooks.TabIndex = 10;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 337);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.btnListAllBooks);
            this.Controls.Add(this.btnSearchByAuthor);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

