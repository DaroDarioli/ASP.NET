using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            clsclientecs clte = new clsclientecs(0, "", "", "");
            clte.Idcliente = int.Parse(txtcliente.Text.Trim());
            clte.Nombre = txtnombre.Text;
            clte.Direccion = txtdireccion.Text;
            clte.Telefono = txttelefono.Text;
            clte.Agregar();
            lblestado.Text = "Registro Agregado con Exito";
            txtcliente.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";


        }
        catch
        {
            lblestado.Text = "Se ha generado una excepcion";
        }
      
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        clsclientecs clte = new clsclientecs(0, "", "", "");
        if (clte.Eliminar(int.Parse(txtcliente.Text)))
        {
            lblestado.Text = "El registro se elimino con exito";
            txtcliente.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";

        }
        else
        {
            lblestado.Text = "El registro no se eliminó";
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        clsclientecs clte = new clsclientecs(0, "", "", "");
        if(clte.Existe(int.Parse(txtcliente.Text)))
        {
            
            txtnombre.Text = clte.Nombre;
            txtdireccion.Text = clte.Direccion;
            txttelefono.Text = clte.Telefono;

            lblestado.Text = "Registro encontrado";

        }
        else
        {
            lblestado.Text = "El registro no existe";
        }
    }

    protected void drpclientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        clsclientecs clte = new clsclientecs(0, "", "", "");
        if (clte.Existe(int.Parse(drpclientes.SelectedValue)))
        {
            txtcliente.Text = clte.Idcliente.ToString();
            txtnombre.Text = clte.Nombre;
            txtdireccion.Text = clte.Direccion;
            txttelefono.Text = clte.Telefono;

            lblestado.Text = "Registro encontrado";

        }
        else
        {
            lblestado.Text = "El registro no existe";
        }
    }
}