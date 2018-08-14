using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Win32;

namespace View
{
    /// Interaction logic for MainWindow.xaml
    public partial class MyAddressBook : Window
    {

        // List<Contact> contacts = new List<Contact>();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MyAddressBook()
        {
            InitializeComponent();

            // adding two example to see how the format fits.
            // contacts.Add(new Contact() { Id = 1, FirstName = "Pero", LastName = "Perica", Residence = "Zagreb", BirthPlace = "Velika Gorica", Gender = "Male", Number = 38511512869, Email = "pero.perica@gmail.com", SocialNetworkId = "pp_erica", Type = "Twitter", Birthday = new DateTime(1998, 3, 1)});
            // contacts.Add(new Contact() { Id = 2, FirstName = "Ivica", LastName = "Ivić", Residence = "Velika Gorica", BirthPlace = "Osijek", Gender = "Male", Number = 385952438719, Email = "iivic@gmail.com", SocialNetworkId = "ivica_ribica", Type = "Facebook", Birthday = new DateTime(1995, 6, 3) });
        
            // dbContacts.ItemsSource = contacts;

            DispatcherTimer Timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        // Method to read audio file.
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
                mediaPlayer.Open(new Uri(openFileDialog.FileName));

            DispatcherTimer Timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        // Calculation of audio duration.
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

        // Still not fully integrated with methods in App.xaml.cs
        // For checking is the new window already opened.
        public static bool IsWindowOpen<T>(string name = "") where T : Window
        {
            return string.IsNullOrEmpty(name)
                ? Application.Current.Windows.OfType<T>().Any()
                : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
        }

        private void BtnAddContact_Click(object sender, RoutedEventArgs e)
        {
            AddNewContact WindowNewContact = new AddNewContact();
            if (!IsWindowOpen<Window>("WindowNewContact"))
            {
                WindowNewContact.Show();
            }
        }

        // Try to find a proper method for selecting single row.
        private void BtnChangeContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteContact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}