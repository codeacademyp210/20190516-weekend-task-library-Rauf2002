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
    public partial class Orders : Form
    {
        LibraryEntities db = new LibraryEntities();
        public Orders()
        {
            InitializeComponent();
            FillOrders();
            ColorDates();
        }

        private void FillOrders()
        {   
            using (LibraryEntities db = new LibraryEntities())
            {  
                ordersTable.Rows.Clear();
                List<Models.Orders> ordersList = db.Orders.ToList();

                foreach (var o in ordersList)
                {
                    ordersTable.Rows.Add(o.Id,
                                         o.Clients.Name + " " + o.Clients.Surname,
                                         o.Books.AuthorsBooks,
                                         o.OrderDate,
                                         o.ReturnDate
                                         );
                }
            }
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            string searchText = orderBox.Text.Trim().ToLower();
            using (LibraryEntities db = new LibraryEntities())
            {
                List<Models.Orders> ordersList = db.Orders.Where(o => o.Clients.Name.ToLower().Contains(searchText) ||
                                                                      o.Clients.Surname.ToLower().Contains(searchText) ||
                                                                      o.OrderDate.ToString().ToLower().Contains(searchText) ||
                                                                      o.ReturnDate.ToString().ToLower().Contains(searchText)).ToList();
                ordersTable.Rows.Clear();
                foreach (var item in ordersList)
                {
                    ordersTable.Rows.Add(item.Id,
                                         item.Clients.Name + " " + item.Clients.Surname,
                                         item.BookId,
                                         item.OrderDate,
                                         item.ReturnDate);
                }
            }
        }

        private void ColorDates()
        {
            foreach (DataGridViewRow row in ordersTable.Rows)
            {
                DateTime value = Convert.ToDateTime(row.Cells[4].Value);
                DateTime criteria = DateTime.Today;
                int result = DateTime.Compare(value, criteria);

                if (result < 0)
                {
                    ColorRows(row, Color.Red);
                    return;
                }
            }
        }

        private void ColorRows(DataGridViewRow row,Color color)
        {
            foreach(DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }
    }
}
