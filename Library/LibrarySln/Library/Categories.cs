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
    public partial class Categories : Form
    {
        LibraryEntities db = new LibraryEntities();

        Models.Categories categoryFound = new Models.Categories();
        public Categories()
        {
            InitializeComponent();
            FillCategories();
            deleteBtn.Enabled = false;
        }

        private void FillCategories()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                categoryTable.Rows.Clear();

                List<Models.Categories> categoryList = db.Categories.ToList();

                foreach (var category in categoryList)
                {
                    categoryTable.Rows.Add(category.Id,
                                           category.Name);
                }
            }
        }

        private void AddCategory(object sender, EventArgs e)
        {
            if (saveBtn.Text == "Save")
            {
                Regex letters = new Regex(@"^[A-Za-z ]+$");
                Match categoryNameMatch = letters.Match(categoryBox.Text);

                if (!categoryNameMatch.Success)
                {
                    MessageBox.Show("Category  contains only letters");
                }
                else
                {
                    Models.Categories c1 = new Models.Categories();
                    c1.Name = categoryBox.Text;

                    using (LibraryEntities db = new LibraryEntities())
                    {
                        db.Categories.Add(c1);
                        db.SaveChanges();
                    }

                    FillCategories();
                    categoryBox.Clear();
                }
            }
            else
            {
                using (LibraryEntities db = new LibraryEntities())
                {

                    int categoryId = Convert.ToInt32(categoryTable.SelectedRows[0].Cells[0].Value);

                    Models.Categories newCat = db.Categories.Where(c => c.Id == categoryFound.Id).FirstOrDefault();

                    newCat.Id = categoryId;
                    Regex letters = new Regex(@"^[A-Za-z ]+$");
                    Match categoryNameMatch = letters.Match(categoryBox.Text);

                    if (!categoryNameMatch.Success)
                    {
                        MessageBox.Show("Category contains only letters");
                    }
                    else
                    {
                        newCat.Name = categoryBox.Text;
                    }

                    db.SaveChanges();
                    FillCategories();
                }
            }
        }

        private void CategoryTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int catId = Convert.ToInt32(categoryTable.Rows[e.RowIndex].Cells[0].Value);

            using (LibraryEntities db = new LibraryEntities())
            {
                categoryFound = db.Categories.Where(c => c.Id == catId).FirstOrDefault();

                if (categoryFound != null)
                {
                    categoryBox.Text = categoryFound.Name;
                }

                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
            }
        }
        private void DeleteCategory(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                int catId = Convert.ToInt32(categoryTable.SelectedRows[0].Cells[0].Value);
                Models.Categories c1 = db.Categories.Where(c => c.Id == catId).FirstOrDefault();
                db.Categories.Remove(c1);
                db.SaveChanges();
            }

            FillCategories();
            Reset();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            categoryBox.Clear();
            saveBtn.Text = "Save";
            deleteBtn.Enabled = false;
        }
    }
}
