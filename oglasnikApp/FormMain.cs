namespace OglasnikApp {
    public partial class FormMain : Form
    {
        Oglasnik oglasnik;

        public FormMain()
        {
            InitializeComponent();
            oglasnik = new Oglasnik();
        }

        //ovdje kao zoves metode da obavlja funkcije kad stisnes gumb, pisem ti da se ne cudis kasnije sto je ovo au
        private void btnAdd_Click(object sender, EventArgs e)
        {
            oglasnik.DodajOglas(new Oglas(tbTitle.Text, tbContent.Text));
            RefreshAdsList();
        }

        private void RefreshAdsList()
        {
            //ako nema ovaj Clear, prikaz ce biti dupliciran od proslih unosa + trenutni
            lbAds.Items.Clear();
            foreach(var oglas in oglasnik.SviOglasi())
            {
                //lbAds
                lbAds.Items.Add(oglas);
            }
        }
    }
}