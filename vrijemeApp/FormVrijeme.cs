namespace VrijemeApp {
  public partial class FormVrijeme : Form {
        Vrijeme vrijeme;

    public FormVrijeme() {
      InitializeComponent();
            vrijeme = new Vrijeme();
            cbGrad.Items.AddRange(vrijeme.DohvatiGradove().ToArray());
    }

    private void cbGrad_SelectedIndexChanged(object sender, EventArgs e) {
      // PrikaziPodatkeZaGrad(cbGrad.Text);
    }
  }
}