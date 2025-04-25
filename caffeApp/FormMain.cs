namespace VubCaffe;
public partial class FormMain : Form
{
    private Bill bill;

    public FormMain()
    {
        InitializeComponent();
        bill = new Bill();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jeste li sigurni da želite izaci iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            Close();
        }
    }

    private void btnEspresso_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Espresso());
        RefreshBill();
    }

    private void btnCappucino_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Cappucino());
        RefreshBill();
    }

    private void btnLatte_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Latte());
        RefreshBill();
    }

    private void btnCocaCola_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new CocaCola());
        RefreshBill();
    }

    private void btnSprite_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Sprite());
        RefreshBill();
    }
    private void btnFanta_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Fanta());
        RefreshBill();
    }

    private void btnIceCream_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new IceCream());
        RefreshBill();
    }

    private void btnCake_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Cake());
        RefreshBill();
    }

    private void btnVoucher100Eur_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Voucher());
        RefreshBill();
    }

    private void btnNewBill_Click(object sender, EventArgs e)
    {
        bill = new Bill();
        RefreshBill();
    }

    private void btnBill_Click(object sender, EventArgs e)
    {
        double total = bill.Total();
        MessageBox.Show($"Ukupan iznos: {total:0.00} EUR", "Naplata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        bill = new Bill();
        RefreshBill();
    }

    private void RefreshBill()
    {
        RefreshItems();
        RefreshTotal();
    }

    private void RefreshItems()
    {
        lbItems.Items.Clear();
        foreach (var product in bill.Products)
        {
            string priceText = (product is Voucher ? "-" : "") + product.Price.ToString("0.00");
            lbItems.Items.Add($"{product.Name} {priceText} EUR");
        }
    }

    private void RefreshTotal()
    {
        lblTotalPrice.Text = $"{bill.Total():0.00} EUR";
    }
}

