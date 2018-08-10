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
    public partial class AddNewContact : Window
    {
        // Window for new contact form
        public AddNewContact()
        {
           InitializeComponent();
        }

        // Method for adding contacts photo to database.
        private void BtnAddNewImage_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                // Set filter for file extension and default file extension 
                DefaultExt = ".png",
                Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            };

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                LoadPhoto.Source = new BitmapImage(new Uri(dlg.FileName));
                photo.Text = dlg.FileName;
            }
        }

        // This method should add data into database.
        // Nothing done.
        // Main method of the app.
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                BirthPlace = birthPlace.Text,
                //Birthday = birthday.SelectedDateFormat,
                //Gender = gender,
                Email = email.Text,
                Comment = comment.Text,
                Image = LoadPhoto.Source,
            };
            string newJson = Newtonsoft.Json.JsonConvert.SerializeObject(contact);
            MessageBox.Show(newJson);
            Close();
        }

        // Closing button which works!
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Definition of contact class
        public class Contact
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

            public ImageSource Image { get; set; }

            public string Comment { get; set; }
        }
    }
}
