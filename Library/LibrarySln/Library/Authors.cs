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
    public partial class Authors : Form
    {
        LibraryEntities db = new LibraryEntities();
        Models.AuthorsBooks ab = new Models.AuthorsBooks();

        Models.Authors authorFound = new Models.Authors();
        public Authors()
        {
            InitializeComponent();
            FillAuthors();
            Reset();
        }

        private void FillAuthors()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                authorTable.Rows.Clear();
                List<Models.Authors> authorsList = db.Authors.ToList();

                foreach(var a in authorsList)
                {
                    authorTable.Rows.Add(a.Id,
                                         a.Name,
                                         a.Surname );
                }
            }
        }

        private void DeleteAuthor(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                int authorId = Convert.ToInt32(authorTable.SelectedRows[0].Cells[0].Value);
                Models.Authors a1 = db.Authors.Where(a => a.Id == authorId).FirstOrDefault();
                db.Authors.Remove(a1);
                db.SaveChanges();
            }
            FillAuthors();
            Reset();
        }

        private void Reset()
        {
            deleteBtn.Enabled = false;
            saveBtn.Text = "Save";
            nameBox.Clear();
            surnameBox.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddAuthor(object sender, EventArgs e)
        {
            if(saveBtn.Text == "Save")
            {
                Regex letters = new Regex(@"^[A-Za-z ]+$");
                Match nameMatch = letters.Match(nameBox.Text);
                Match surnameMatch = letters.Match(surnameBox.Text);

                if(nameMatch.Success && surnameMatch.Success)
                {
                    Models.Authors a1 = new Models.Authors();
                    a1.Id = ab.AuthorId;
                    a1.Name = nameBox.Text;
                    a1.Surname = surnameBox.Text;


                    using (LibraryEntities db = new LibraryEntities())
                    {
                        db.Authors.Add(a1);
                        db.SaveChanges();
                    }

                    FillAuthors();
                    nameBox.Clear();
                    surnameBox.Clear();
                } else
                {
                    MessageBox.Show("Surname and name contain only letters");
                }
            }
            else
            {
                using(LibraryEntities db  =new LibraryEntities())
                {
                    int authorId = Convert.ToInt32(authorTable.SelectedRows[0].Cells[0].Value);

                    Models.Authors newAuthor = db.Authors.Where(a => a.Id == authorFound.Id).FirstOrDefault();

                    newAuthor.Id = authorId;
                    Regex letters = new Regex(@"^[A-Za-z ]+$");
                    Match nameMatch = letters.Match(nameBox.Text);
                    Match surnameMatch = letters.Match(surnameBox.Text);

                    if (nameMatch.Success && surnameMatch.Success)
                    {
                        newAuthor.Name = nameBox.Text;
                        newAuthor.Surname = surnameBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Surname and name contain only letters");
                    }
                    db.SaveChanges();
                    FillAuthors();
                }
            }
        }

        private void AuthorTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int authorId = Convert.ToInt32(authorTable.Rows[e.RowIndex].Cells[0].Value);

            using (LibraryEntities db = new LibraryEntities())
            {
                authorFound = db.Authors.Where(a => a.Id == authorId).FirstOrDefault();
                if(authorFound != null)
                {
                    nameBox.Text = authorFound.Name;
                    surnameBox.Text = authorFound.Surname;
                }

                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
            }
        }
    }
}
