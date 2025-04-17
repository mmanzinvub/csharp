namespace fuelCalculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            fuelCalculator calculator = new fuelCalculator();

            calculator.fuelConsuption = Convert.ToDouble(textPotrosnja.Text);
            calculator.tripLength = Convert.ToInt32(textDuzina.Text);
            calculator.fuelPrice = Convert.ToDouble(textTarifa.Text);

            double fuelNeededTrip = calculator.CalculateFuel();
            double fuelCostTotal = calculator.CalculateCost();

            /* U inpute moras unijeti sa decimalnim zarezom (npr 8,0) jer ako je unos 8.0 
            * on ce krivo prikazivati dolje 
            * 
            * Parsing Issue:
            * Methods like Convert.ToDouble() or double.Parse() rely on the system's 
            * current culture to interpret numbers.
            * If your culture expects commas, using dots will 
            * lead to incorrect parsing.
            */
            textGorivo.Text = fuelNeededTrip.ToString("F2");      
            textPlatiti.Text = fuelCostTotal.ToString("F2");      
        }
    }
}