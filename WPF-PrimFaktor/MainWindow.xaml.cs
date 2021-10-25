using System.Windows;

namespace WPF_PrimFaktor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zahl;
        string eingabe, ergebnis;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrimFaktor primFaktor = new PrimFaktor();

            eingabe = Input.Text;

            bool pruefung = int.TryParse(eingabe, out zahl);

            if (pruefung && zahl > 1)
            {
                Input.Text = "";
                ergebnis = primFaktor.Zerlegung(zahl);
            }
            else
            {
                Input.Text = "";
                MessageBox.Show("Bitte eine Zahl größer 2 eingeben");
            }

            Output.Text = ergebnis;
        }
    }
}
