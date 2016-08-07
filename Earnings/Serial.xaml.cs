using System.Windows;

namespace Earnings
{
    public partial class Serial : MovieEdit
    {
        public Serial(Movie movie)
        {
            InitializeComponent();
            base.Title = movie.Name;
            cost.Text = movie.Cost.ToString();
            duesTV.Text = movie.DuesTV.ToString();
            duesExtra.Text = movie.DuesExtra.ToString();
        }
        private void _calc_Click(object sender, RoutedEventArgs e)
        {
            base.calculate(double.Parse(cost.Text), double.Parse(duesTV.Text) + double.Parse(duesExtra.Text), "сериала");
        }
        private void _save_Click(object sender, RoutedEventArgs e)
        {
            base.save(int.Parse(cost.Text), null, int.Parse(duesTV.Text),
                int.Parse(duesExtra.Text), null, null);
        }
        private void _cancel_Click(object sender, RoutedEventArgs e)
        {
            base.cancel();
        }
    }
}