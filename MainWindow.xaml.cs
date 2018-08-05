﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Address_book
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyAddressBook : Window
    {
        public MyAddressBook()
        {
            InitializeComponent();

            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Birthday = new DateTime(1992,9,7) });

        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddNewUser win2 = new AddNewUser();
            win2.Show();
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {

        }

        public class User
        {
            public int Id { get; set; }

            public DateTime Birthday { get; set; }
        }
    }
}
