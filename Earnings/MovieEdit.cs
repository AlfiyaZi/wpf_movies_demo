using System.Windows;

namespace Earnings
{
    public class MovieEdit : Window
    {
        protected Movie movie;
        protected void calculate(double cost, double cash, string type)
        {
            double result = (cash - cost) / 1000000;
            if (result > 0)
            {
                MessageBox.Show("Доход от " + type + " \"" + Title + "\":\n" + result + " млн.");
            }
            else
            {
                MessageBox.Show("Убыток " + type + " \"" + Title + "\":\n" + -result + " млн.");
            }
        }
        protected void save(int Cost, int? Dues, int DuesTV, int DuesExtra, short? CinemaPart, short? DistrPart)
        {
            MessageBoxResult view = MessageBox.Show("Сохранить изменения?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (view == MessageBoxResult.Yes)
            {
                movie.Cost = Cost;
                if (Dues != null) movie.Dues = (int)Dues;
                if (CinemaPart != null) movie.CinemaPart = (short)CinemaPart;
                if (DistrPart != null) movie.DistrPart = (short)DistrPart;
                movie.DuesTV = DuesTV;
                movie.DuesExtra = DuesExtra;
                Close();
            }
        }
        protected void cancel()
        {
            MessageBoxResult view = MessageBox.Show("Отменить изменения?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (view == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}