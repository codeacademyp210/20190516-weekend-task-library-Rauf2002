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
    public partial class Clients : Form
    {

        LibraryEntities db = new LibraryEntities();
        Models.Clients clientFound = new Models.Clients();
        public Clients()
        {
            InitializeComponent();
            FIllClients();
            deleteBtn.Enabled = false;
        }

        private void FIllClients()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                clientTable.Rows.Clear();

                List<Models.Clients> clients = db.Clients.ToList();

                foreach (var client in clients)
                {
                    clientTable.Rows.Add(client.Id,
                                       client.Name,
                                       client.Surname,
                                       client.Phone,
                                       client.Email);
                }

            }
        }


        private void AddClient(object sender, EventArgs e)
        {
            if(saveBtn.Text == "Save")
            {
                Regex letters = new Regex(@"^[A-Za-z ]+$");
                Match nameMatch = letters.Match(nameBox.Text);
                Match surnameMatch = letters.Match(surnameBox.Text);

                Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match emailMatch = email.Match(emailBox.Text);

                Regex phone = new Regex(@"^[+0-9]*$");
                Match phoneMatch = phone.Match(phoneBox.Text);

                if(!nameMatch.Success || !surnameMatch.Success)
                {
                    MessageBox.Show("Name and surname contain only letters");
                }
                else  if (!emailMatch.Success)
                {
                    MessageBox.Show("Please , enter a valid email");
                }
                else if (!phoneMatch.Success)
                {
                    MessageBox.Show("Please , enter a valid phone number");
                }
                else
                {
                    Models.Clients c1 = new Models.Clients
                    {
                        Name = nameBox.Text,
                        Surname = surnameBox.Text,
                        Email = emailBox.Text,
                        Phone = phoneBox.Text
                    };

                    using (LibraryEntities db = new LibraryEntities())
                    {
                        db.Clients.Add(c1);
                        db.SaveChanges();
                    }

                    FIllClients();
                    nameBox.Clear();
                    surnameBox.Clear();
                    emailBox.Clear();
                    phoneBox.Clear();

                }
            }
            else
            {
                using (LibraryEntities db = new LibraryEntities())
                {

                    int clientId = Convert.ToInt32(clientTable.SelectedRows[0].Cells[0].Value);

                    Models.Clients newClient = db.Clients.Where(c => c.Id == clientFound.Id).FirstOrDefault();

                    newClient.Id = clientId;


                    Regex letters = new Regex(@"^[A-Za-z ]+$");
                    Match nameMatch = letters.Match(nameBox.Text);
                    Match surnameMatch = letters.Match(surnameBox.Text);

                    Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match emailMatch = email.Match(emailBox.Text);

                    Regex phone = new Regex(@"^[+0-9]*$");
                    Match phoneMatch = phone.Match(phoneBox.Text);

                    if (!nameMatch.Success || !surnameMatch.Success)
                    {
                        MessageBox.Show("Name and surname contain only letters");
                    }
                    else if (!emailMatch.Success)
                    {
                        MessageBox.Show("Please , enter a valid email");
                    }
                    else if (!phoneMatch.Success)
                    {
                        MessageBox.Show("Please , enter a valid phone number");
                    }
                    else
                    {
                        newClient.Name = nameBox.Text;
                        newClient.Surname = surnameBox.Text;
                        newClient.Email = emailBox.Text;
                        newClient.Phone = phoneBox.Text;
                    }

                    db.SaveChanges();
                    FIllClients();
                }
            }
        }

        private void DeleteClient(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                    int clientId = Convert.ToInt32(clientTable.SelectedRows[0].Cells[0].Value);
                    Models.Clients c1 = db.Clients.Where(c => c.Id == clientId).FirstOrDefault();
                    db.Clients.Remove(c1);
                    db.SaveChanges();
            }
            FIllClients();
            Reset();
        }

        private void Reset()
        {
            nameBox.Clear();
            surnameBox.Clear();
            emailBox.Clear();
            phoneBox.Clear();
            saveBtn.Text = "Save";
            deleteBtn.Enabled = false;
        }

        private void ClientTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clientId = Convert.ToInt32(clientTable.Rows[e.RowIndex].Cells[0].Value);

            using (LibraryEntities db = new LibraryEntities())
            {
                clientFound = db.Clients.Where(c => c.Id == clientId).FirstOrDefault();

                if (clientFound != null)
                {
                    nameBox.Text = clientFound.Name;
                    surnameBox.Text = clientFound.Surname;
                    emailBox.Text = clientFound.Email;
                    phoneBox.Text = clientFound.Phone;
                }

                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
