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

namespace StudentePerUnGiorno2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sld1.Minimum = 0;
            sld1.Maximum = 50;
            sld2.Minimum = 0;
            sld2.Maximum = 50;
        }
        int somma;
        int sottrazione;
        int prodotto;
        int divisione;
        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                int n1 = (int)sld1.Value;
                txt1.Text = n1.ToString();
                int n2 = (int)sld2.Value;
                txt2.Text = n2.ToString();
                somma = n1 + n2;
                txtSomma.Text = somma.ToString();
                sottrazione = n1 - n2;
                txtSottrazione.Text = sottrazione.ToString();
                prodotto = n1 * n2;
                txtProdotto.Text = prodotto.ToString();
                divisione = n1 / n2;
                txtDivisione.Text = divisione.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sld2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                int n1 = (int)sld1.Value;
                txt1.Text = n1.ToString();
                int n2 = (int)sld2.Value;
                txt2.Text = n2.ToString();
                somma = n1 + n2;
                txtSomma.Text = somma.ToString();
                sottrazione = n1 - n2;
                txtSottrazione.Text = sottrazione.ToString();
                prodotto = n1 * n2;
                txtProdotto.Text = prodotto.ToString();
                divisione = n1 / n2;
                txtDivisione.Text = divisione.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbox_Checked(object sender, RoutedEventArgs e)
        {
            sld1.IsEnabled = true;
            sld2.IsEnabled = true;
        }

        private void cbox_Unchecked(object sender, RoutedEventArgs e)
        {
            sld1.IsEnabled = false;
            sld2.IsEnabled = false;
        }
    }
}
