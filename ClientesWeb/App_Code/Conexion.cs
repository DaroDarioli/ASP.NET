using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Clase conexion del cliente
/// </summary>
public class Conexion
{
    protected SqlDataReader reader;

    protected SqlDataAdapter adaptadorDeDatos;

    protected DataSet data;

    protected SqlConnection aconeccion = new SqlConnection();

    public Conexion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void Conectar(string table)
    {
        string strConeccion = ConfigurationManager.ConnectionStrings["clientesConnectionString"].ConnectionString;
        aconeccion.ConnectionString = strConeccion;
        aconeccion.Open();
        adaptadorDeDatos = new SqlDataAdapter("select  * from " + table, aconeccion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(adaptadorDeDatos);
        Data = new DataSet();

        adaptadorDeDatos.Fill(Data, table);
        aconeccion.Close();
    }

    public DataSet Data
    {
        set { data = value; }
        get { return data; }
    }

    public SqlDataReader DataReader
    {

        set { reader = value; }
        get { return  reader;  }
    }

}