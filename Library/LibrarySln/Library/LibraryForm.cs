using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;


namespace Library
{
    public partial class LibraryForm : Form
    {
        LibraryEntities db = new LibraryEntities();

        public LibraryForm()
        {
            InitializeComponent();
            FillClients();
            FillBooks();
        }

        public void FillClients()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                userTable.Rows.Clear();

                List<Models.Clients> clients = db.Clients.ToList();

                foreach (var client in clients)
                {
                    userTable.Rows.Add(client.Id,
                                       client.Name,
                                       client.Surname,
                                       client.Phone,
                                       client.Email);
                }

            }
        }
        private void FillBooks()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                bookTable.Rows.Clear();

                List<Models.Books> books = db.Books.ToList();

                foreach (var book in books)
                {
                    bookTable.Rows.Add(book.Id,
                                       book.Name,
                                       book.AuthorsBooks,
                                       book.Price,
                                       book.Quantity,
                                       book.Categories.Name);
                }

            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(userTable.SelectedRows[0].Cells[0].Value);
            int bookID = Convert.ToInt32(bookTable.SelectedRows[0].Cells[0].Value);
            Models.Orders order = new Models.Orders();
            order.ClientId = clientID;
            order.BookId = bookID;
            order.OrderDate = DateTime.Now;
            order.ReturnDate = DateTime.Now.AddMonths(1);

            using (LibraryEntities db = new LibraryEntities())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        private void SearchUser(object sender, EventArgs e)
        {
            string searchText = UserBox.Text.Trim().ToLower();
            using (LibraryEntities db = new LibraryEntities())
            {
                List<Models.Clients> clientsList = db.Clients.Where(c =>
                                                                    c.Name.ToLower().Contains(searchText) ||
                                                                    c.Email.ToLower().Contains(searchText) ||
                                                                    c.Phone.ToLower().Contains(searchText) ||
                                                                    c.Surname.ToLower().Contains(searchText)).ToList();

                userTable.Rows.Clear();
                foreach (var item in clientsList)
                {
                    userTable.Rows.Add(item.Id,
                                       item.Name,
                                       item.Surname,
                                       item.Phone,
                                       item.Email);
                }
            }
        }

        private void SearchBook(object sender, EventArgs e)
        {
            string searchText = bookBox.Text.Trim().ToLower();
            using (LibraryEntities db = new LibraryEntities())
            {
                List<Models.Books> booksList = db.Books.Where(b =>
                                                                    b.Name.ToLower().Contains(searchText) ||
                                                                    b.Categories.Name.ToLower().Contains(searchText)).ToList();

                bookTable.Rows.Clear();
                foreach (var item in booksList)
                {
                    bookTable.Rows.Add(item.Id,
                                       item.Name,
                                       item.Price,
                                       item.Quantity,
                                       item.Categories.Name);
                }
            }
        }

        private void CreateCategory(object sender, EventArgs e)
        {
            Categories catForm = new Categories();
            catForm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillClients();
            FillBooks();
        }

        private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors authorForm = new Authors();
            authorForm.ShowDialog();
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orderForm = new Orders();
            orderForm.ShowDialog();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books bookForm = new Books();
            bookForm.ShowDialog();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients clientForm = new Clients();
            clientForm.ShowDialog();
        }
    }
}
