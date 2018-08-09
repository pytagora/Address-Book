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
using System.Windows.Threading;
using Microsoft.Win32;

namespace Address_book
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyAddressBook : Window
    {

        List<User> Users = new List<User>();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MyAddressBook()
        {
            InitializeComponent();

            Users.Add(new User() { Id = 1, FirstName = "Pero", LastName = "Perica", Residence = "Zagreb", BirthPlace = "Velika Gorica", Gender = "Male", PhoneNumber = 38511512869, Email = "pero.perica@gmail.com", SocialNetworkId = "pp_erica", Type = "Twitter", Birthday = new DateTime(1998, 3, 1)});
            Users.Add(new User() { Id = 2, FirstName = "Valentino", LastName = "Skobljanec", Residence = "Kukuljanovo", BirthPlace = "Rijeka", Gender = "Male", PhoneNumber = 385953928381, Email = "vskobljanec@gmail.com", SocialNetworkId = "vale_n_tino92", Type = "Instagram", Birthday = new DateTime(1992, 9, 7) });
        
            dbUsers.ItemsSource = Users;

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                mediaPlayer.Open(new Uri(openFileDialog.FileName));

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                if (mediaPlayer.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
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

            public string Comment { get; set; }

            public string Image { get; set; }
        }

    }
}