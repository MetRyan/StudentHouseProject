﻿using BusinessObjects;
using Repositories;
using Repositories.Interface;
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

namespace StudentHouseProject.User
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        ICustomerRepository repository = new CustomerRepository();
        public void reset()
        {
            txtEmail.Text = "";
            dtpDob.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            cbGender.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(dtpDob.Text) ||
                  string.IsNullOrWhiteSpace(cbGender.Text))
            {
                MessageBox.Show("All fields are required!", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Invalid email format. Please use a valid @gmail.com email.", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhone.Text.Length < 9 || txtPhone.Text.Length > 11)
            {
                MessageBox.Show("Phone number must be between 9 and 11 characters.", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!DateTime.TryParse(dtpDob.Text, out var dateOfBirth) || dateOfBirth >= DateTime.Now)
            {
                MessageBox.Show("Invalid date of birth. Please use a valid date before today.", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbGender.Text != "Male" && cbGender.Text != "Female")
            {
                MessageBox.Show("Invalid gender. Please specify 'Male' or 'Female'.", "Registration Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Customer p = new Customer()
                {

                    DateCreated = DateTime.Now,
                    Email = txtEmail.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Dob = dateOfBirth,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,
                    Sex = cbGender.SelectedItem.ToString(),

                };
                repository.AddCustomer(p);

                    MessageBox.Show("succesfull", "Register",
                MessageBoxButtons.OK, MessageBoxIcon.Error);






        }


        }
    }
}
