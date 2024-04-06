namespace SalSystem.Views
{
    public partial class F_CadClientes : Form
    {    
        public F_CadClientes()
        {
            InitializeComponent();
        }

        //readonly GetCEP getCEP = new();


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
           GetCEP(TxtCEP.Text);   
        }

        private async Task GetCEP(string _cep)
        {
            CepService cepService = new();

            string result = await cepService.GetCityByCepAsync(_cep);
            txtCidade.Text = result;
        }
    }
}
