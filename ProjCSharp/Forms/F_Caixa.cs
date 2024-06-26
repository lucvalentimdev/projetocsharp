﻿using SalSystem.Models;
using SalSystem.Services;
using SalSystem.Services.DataAcess;

namespace SalSystem.Forms;

public partial class F_Caixa : Form
{
    public F_Caixa()
    {
        InitializeComponent();
    }

    //var//
    readonly DataController dataController = new();

    private void BtnConsultar_Click(object sender, EventArgs e)
    {
        int _idCliente = 0;

        if (txtCPF.Text != "")
        {
            List<Cliente> _listaCliente = Cliente.EncontrarCliente(txtCPF.Text);
            foreach (Cliente _cliente in _listaCliente)
                _idCliente = _cliente.IdCliente;
        }

        DateTime _dateInicial = dateInicio.Value;           //<-- Atribui os valores do DateTimePicker em váriaveis para conversão e eliminação das horas e min // 
        DateTime _dateFinal = dateFinal.Value.AddDays(1);   //<-- Acrescenta 1 dia + na data final para encontrar vendas do dia //

        gridCaixa.DataSource = DataTableAssistant.ProcessData(dataController.GetInfoCaixa(cboFormaReceb.Text, _idCliente, _dateInicial.Date,_dateFinal.Date));
    }

    private void BtnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void F_Caixa_Load(object sender, EventArgs e)
    {
        BtnConsultar_Click(sender, e);
    }

    private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
    {
        Utilities.NumbersOnly(e);
    }

    private void BtnLimpar_Click(object sender, EventArgs e)
    {
        txtCPF.Text = string.Empty;
        cboFormaReceb.Text = string.Empty;
        gridCaixa.DataSource = null;
        dateInicio.Value = DateTime.Now;
        dateFinal.Value = DateTime.Now;
    }
}
