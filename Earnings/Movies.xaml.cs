using System.Collections.Generic;
using System.Windows;

namespace Earnings
{
    public class Movie
    {
        public Movie(string Name, byte Type, int Cost, int? Dues, int DuesTV, int DuesExtra, short? CinemaPart, short? DistrPart)
        {
            this.Name = Name;
            this.Type = Type;
            this.Cost = Cost;
            this.Dues = Dues;
            this.DuesTV = DuesTV;
            this.DuesExtra = DuesExtra;
            this.CinemaPart = CinemaPart;
            this.DistrPart = DistrPart;
        }
        public string Name { get; set; }
        public byte Type { get; set; }
        public int Cost { get; set; }
        public int? Dues { get; set; }
        public int DuesTV { get; set; }
        public int DuesExtra { get; set; }
        public short? CinemaPart { get; set; }
        public short? DistrPart { get; set; }
    }
    public partial class Movies : Window
    {
        public Movies()
        {
            InitializeComponent();
            List<Movie> movies = new List<Movie>()
            {
                new Movie("Охотники за головами", 0, 100000000, 200000000, 40000000, 10000000, 55, 10),
                new Movie("Сумерки", 0, 160000000, 300000000, 60000000, 20000000, 50, 11),
                new Movie("Подземелье", 1, 6000000, null, 22000000, 2000000, null, null),
                new Movie("Заложники Юпитера", 1, 11000000, null, 4000000, 600000, null, null)
            };
            movieList.ItemsSource = movies;
            movieList.DisplayMemberPath = "Name";
        }
        private void calc_Click(object sender, RoutedEventArgs e)
        {
            if (movieList.SelectedIndex != -1)
            {
                Movie movie = ((Movie)movieList.SelectedItem);
                switch (movie.Type)
                {
                    case 0:
                        Film film = new Film(movie);
                        film.ShowDialog();
                        break;
                    default:
                        Serial serial = new Serial(movie);
                        serial.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Выберите кинофильм из списка");
            }
        }
        private void movieList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (((Movie)movieList.SelectedItem).Type == 0)
                Type.Content = "Фильм";
            else
                Type.Content = "Сериал";
        }
    }
}