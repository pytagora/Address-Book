using System;
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
using System.Windows.Shapes;
using static Address_book.MyAddressBook;

namespace Address_book
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {

        public AddNewUser()
        {
           InitializeComponent();
        }

        private void BtnAddNewImage_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                photofile.Text = filename;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<User> Users = new List<User>();
            Users.Add(new User() { Id = 3, FirstName = "asd", LastName = "asd", Residence = "a", BirthPlace = "Velika asd", Gender = "Male", PhoneNumber = 213123123, Email = "pero.ads@gmail.com", SocialNetworkId = "", Type = "" });
            //this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public class User
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string BirthPlace { get; set; }

            public DateTime Birthday { get; set; }

            public string Gender { get; set; }

            public string Residence { get; set; }

            public string Email { get; set; }

            public long PhoneNumber { get; set; }

            public string SocialNetworkId { get; set; }

            public string Type { get; set; }
        }

    }
}
