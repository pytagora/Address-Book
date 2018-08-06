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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;

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
            users.Add(new User() { Id = 1, FirstName = "Pero", LastName = "Perica", Residence = "Zagreb", BirthPlace = "Velika Gorica", Gender = "Male", PhoneNumber = 38511512869, Email = "pero.perica@gmail.com", SocialNetworkId = "pp_erica", Type = "Twitter", Birthday = new DateTime(1998, 3, 1)});
            users.Add(new User() { Id = 2, FirstName = "Valentino", LastName = "Skobljanec", Residence = "Kukuljanovo", BirthPlace = "Rijeka", Gender = "Male", PhoneNumber = 385953928381, Email = "vskobljanec@gmail.com", SocialNetworkId = "vale_n_tino92", Type = "Instagram", Birthday = new DateTime(1992, 9, 7) });
        
            dbUsers.ItemsSource = users;
        }

        public static bool IsWindowOpen<T>(string name = "") where T : Window
        {
            return string.IsNullOrEmpty(name)
                ? Application.Current.Windows.OfType<T>().Any()
                : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddNewUser WindowNewUser = new AddNewUser();
            if (!IsWindowOpen<Window>("WindowNewUser"))
            {
                WindowNewUser.Show();
            }
        }

        private void BtnChangeUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            
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