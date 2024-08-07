using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1._0
{
    public partial class Form1 : Form
    {
        private Library library;

        public Form1()
        {
            InitializeComponent();
            library = new Library();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = new Book(
                int.Parse(txtId.Text),
                txtTitle.Text,
                txtAuthor.Text,
                int.Parse(txtYear.Text),
                txtISBN.Text
            );
            library.AddBook(book);
            MessageBox.Show("Book added successfully!");
            ClearTextBoxes();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (library.RemoveBook(int.Parse(txtId.Text)))
            {
                MessageBox.Show("Book removed successfully!");
            }
            else
            {
                MessageBox.Show("Book not found!");
            }
            ClearTextBoxes();
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            var books = library.SearchByTitle(txtTitle.Text);
            DisplayBooks(books);
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            var books = library.SearchByAuthor(txtAuthor.Text);
            DisplayBooks(books);
        }

        private void btnListAllBooks_Click(object sender, EventArgs e)
        {
            var books = library.GetAllBooks();
            DisplayBooks(books);
        }

        private void DisplayBooks(List<Book> books)
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add($"{book.Id}: {book.Title} by {book.Author} (Published: {book.YearPublished}, ISBN: {book.ISBN})");
            }
        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtISBN.Clear();
        }
    }
}
