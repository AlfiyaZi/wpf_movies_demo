using System.Windows;

namespace Earnings
{
    public partial class Film : MovieEdit
    {
        public Film(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            base.Title = movie.Name;
            cost.Text = movie.Cost.ToString();
            dues.Text = movie.Dues.ToString();
            cinemaPart.Text = movie.CinemaPart.ToString();
            distrPart.Text = movie.DistrPart.ToString();
            duesTV.Text = movie.DuesTV.ToString();
            duesExtra.Text = movie.DuesExtra.ToString();
        }
        private void _calc_Click(object sender, RoutedEventArgs e)
        {
            base.calculate(double.Parse(cost.Text),
                double.Parse(dues.Text) * (100 - double.Parse(cinemaPart.Text) - double.Parse(distrPart.Text)) / 100
                + double.Parse(duesTV.Text) + double.Parse(duesExtra.Text), "фильма");
        }
        private void _save_Click(object sender, RoutedEventArgs e)
        {
            base.save(int.Parse(cost.Text), int.Parse(dues.Text), int.Parse(duesTV.Text),
                int.Parse(duesExtra.Text), short.Parse(cinemaPart.Text), short.Parse(distrPart.Text));
        }
        private void _cancel_Click(object sender, RoutedEventArgs e)
        {
            base.cancel();
        }
    }
}