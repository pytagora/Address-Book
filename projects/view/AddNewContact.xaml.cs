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
using static View.MyAddressBook;

namespace View
{
    /// Interaction logic for AddNewContact.xaml
    public partial class AddNewContact : Window
    {
        // Window for new contact form
        public AddNewContact()
        {
           InitializeComponent();
        }

        // Add contact's photo.
        /*private void BtnAddNewImage_Click(object sender, RoutedEventArgs e)
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
        }*/

        // Main method of the app.
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            /*Contact contact = new Contact
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                BirthPlace = birthPlace.Text,
                //Birthday = birthday.SelectedDateFormat,
                //Gender = gender,
                Email = email.Text,
                Comment = comment.Text,
            };
            string newJson = Newtonsoft.Json.JsonConvert.SerializeObject(contact);
            MessageBox.Show(newJson);
            Close();*/
        }

        // Close window.
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
