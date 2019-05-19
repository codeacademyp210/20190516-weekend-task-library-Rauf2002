using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class Books : Form
    {
        LibraryEntities db = new LibraryEntities();

        Models.Books bookFound = new Models.Books();
        public Books()
        {
            InitializeComponent();
            FillBooks();
            FillCatDrop();
            deleteBtn.Enabled = false;
            FillAuthorDrop();
        }

        private void FillBooks()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                bookTable.Rows.Clear();
                List<Models.Books> booksList = db.Books.ToList();
                //List<Models.AuthorsBooks> abList = db.AuthorsBooks.ToList();
                foreach (var b in booksList)
                {
                    bookTable.Rows.Add(b.Id,
                                b.Name,
                                b.AuthorsBooks,
                                b.Price,
                                b.Categories.Name,
                                b.Quantity);
                }



                //foreach (var y in abList)
                //{
                //    bookTable.Rows.Add(y.Authors.Name + " " + y.Authors.Surname);
                //}
                //foreach (var b in booksList)
                //{
                //    bookTable.Rows.Add(b.Price,
                //                b.Categories.Name,
                //                b.Quantity);
                //}

                //foreach (var b in booksList)
                //{
                //    foreach (DataGridViewRow row in bookTable.Rows)
                //    {
                //        row.Cells[0].Value = b.Id;
                //        row.Cells[1].Value = b.Name;
                //        foreach(var y in abList)
                //        {
                //            row.Cells[2].Value = y.Authors.Name;
                //        }
                //        row.Cells[3].Value = b.Price;
                //        row.Cells[4].Value = b.Categories.Name;
                //        row.Cells[5].Value = b.Quantity;
                //    }
                //}
            }
        }

        private void FillAuthorDrop()
        {
            authorDrop.Items.Clear();

            List<Models.Authors> authorsList = db.Authors.ToList();
            foreach (var item in authorsList)
            {
                authorDrop.Items.Add(item.Name + " " + item.Surname);
            }
        }

        private void FillCatDrop()
        {
            categoryDrop.Items.Clear();

            List<Models.Categories> categoryList = db.Categories.ToList();
            foreach (var item in categoryList)
            {
                categoryDrop.Items.Add(item.Name);
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            if (saveBtn.Text == "Save")
            {
                Regex letters = new Regex(@"^[A-Za-z ]+$");
                Match bookNameMatch = letters.Match(nameBox.Text);

                Regex price = new Regex(@"^[0-9.]*$");
                Match priceMatch = price.Match(priceBox.Text);

                Regex numbers = new Regex(@"^[0-9]*$");
                Match quantityMatch = numbers.Match(quantityBox.Text);

                if (!bookNameMatch.Success)
                {
                    MessageBox.Show("Book name contains only letters");
                }
                else if (!priceMatch.Success)
                {
                    MessageBox.Show("Price contains only numbers and dot");
                }
                else if (!quantityMatch.Success)
                {
                    MessageBox.Show("Quantity contains only numbers");
                }
                else
                {
                    using (LibraryEntities db = new LibraryEntities())
                    {
                        Models.AuthorsBooks ab = new AuthorsBooks();
                        int categoryId = (db.Categories.Where(c => c.Name == categoryDrop.SelectedItem.ToString()).FirstOrDefault()).Id;
                        int authorId = (db.Authors.Where(a => a.Name + " " + a.Surname == authorDrop.SelectedItem.ToString()).FirstOrDefault()).Id;
                        Models.Books b1 = new Models.Books();
                        b1.Name = nameBox.Text;
                        ab.BookId = b1.Id;
                        ab.AuthorId = authorId;
                        db.AuthorsBooks.Add(ab);
                        b1.Price = Convert.ToDecimal(priceBox.Text);
                        b1.CategoryId = categoryId;
                        b1.Quantity = Convert.ToInt32(quantityBox.Text);
                        db.Books.Add(b1);
                        db.SaveChanges();
                    }
                    FillBooks();
                    nameBox.Clear();
                    priceBox.Clear();
                    quantityBox.Clear();
                    categoryDrop.SelectedIndex = -1;
                    authorDrop.SelectedIndex = -1;
                }
            }
            else
            {
                using (LibraryEntities db = new LibraryEntities())
                {

                    int bookId = Convert.ToInt32(bookTable.SelectedRows[0].Cells[0].Value);

                    Models.Books newBook = db.Books.Where(b => b.Id == bookFound.Id).FirstOrDefault();

                    newBook.Id = bookId;
                    Regex letters = new Regex(@"^[A-Za-z ]+$");
                    Match bookNameMatch = letters.Match(nameBox.Text);

                    Regex price = new Regex(@"^[0-9.]*$");
                    Match priceMatch = price.Match(priceBox.Text);

                    Regex numbers = new Regex(@"^[0-9]*$");
                    Match quantityMatch = numbers.Match(quantityBox.Text);

                    if (!bookNameMatch.Success)
                    {
                        MessageBox.Show("Book name contains only letters");
                    }
                    else if (!priceMatch.Success)
                    {
                        MessageBox.Show("Price contains only numbers and dot");
                    }
                    else if (!quantityMatch.Success)
                    {
                        MessageBox.Show("Quantity contains only numbers");
                    }
                    else
                    {
                        newBook.Name = nameBox.Text;
                        newBook.Categories.Name = (db.Categories.Where(c => c.Name == categoryDrop.SelectedItem.ToString()).FirstOrDefault()).Name;
                        newBook.Price = Convert.ToDecimal(priceBox.Text);
                        newBook.Quantity = Convert.ToInt32(quantityBox.Text);
                    }

                    db.SaveChanges();
                    FillBooks();
                    Reset();
                }
            }
        }

        private void Reset()
        {
            deleteBtn.Enabled = false;
            saveBtn.Text = "Save";
            nameBox.Clear();
            priceBox.Clear();
            quantityBox.Clear();
            categoryDrop.SelectedIndex = -1;
            authorDrop.SelectedIndex = -1;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                int bookId = Convert.ToInt32(bookTable.SelectedRows[0].Cells[0].Value);
                Models.Books b1 = db.Books.Where(b => b.Id == bookId).FirstOrDefault();
                db.Books.Remove(b1);
                db.SaveChanges();
            }

            FillBooks();
            Reset();
        }

        private void BookTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bookId = Convert.ToInt32(bookTable.Rows[e.RowIndex].Cells[0].Value);

            using (LibraryEntities db = new LibraryEntities())
            {
                bookFound = db.Books.Where(b => b.Id == bookId).FirstOrDefault();
                List<Models.AuthorsBooks> abList = db.AuthorsBooks.ToList();

                if (bookFound != null)
                {
                    nameBox.Text = bookFound.Name;
                    //foreach(var y in abList)
                    //{   
                    //    if(bookFound.Id == y.BookId)
                    //    {
                    //        authorDrop.SelectedText = y.Authors.Name;
                    //    }
                    //}
                    priceBox.Text = Convert.ToString(bookFound.Price);
                    quantityBox.Text = Convert.ToString(bookFound.Quantity);
                    categoryDrop.SelectedItem = bookFound.Categories.Name;
                }
                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
            }
        }
    }
}
