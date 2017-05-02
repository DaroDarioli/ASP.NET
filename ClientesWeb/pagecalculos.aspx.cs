using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagecalculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clscalculos calculo = new clscalculos(0, 0, 0);
        if(rdbcalculos.SelectedValue == "1")        
            txtResultado.Text = calculo.Suma(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();
        
        else if(rdbcalculos.SelectedValue == "2")        
            txtResultado.Text = calculo.Resta(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();

        
        else if (rdbcalculos.SelectedValue == "3")        
            txtResultado.Text = calculo.Producto(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();

        else
           txtResultado.Text = "0";

    }
}