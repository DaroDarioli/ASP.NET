using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Clase clientes
/// </summary>
public class clsclientecs : Conexion
{

    string table = "cliente"; // nombre de la tabla
    protected string nombre, direccion, telefono;
    protected int idcliente;

    public clsclientecs(int idcliente, string nombre, string direccion, string telefono)
    {
        this.idcliente = idcliente;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    // metodos para establecer y recuperar datos 

    public int Idcliente
    {
        set { idcliente = value; }
        get { return idcliente; }
    }

    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }

    public string Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }

    public string Telefono
    {
        set { telefono = value; }
        get { return telefono; }
    }

    //metodo para agregar registro a DB

    public void Agregar()
    {
        Conectar(table);
        DataRow fila;
        fila = Data.Tables[table].NewRow();
        fila["idcliente"] = Idcliente;
        fila["nombre"] = Nombre;
        fila["direccion"] = Direccion;
        fila["telefono"] = Telefono;

        Data.Tables[table].Rows.Add(fila);
        adaptadorDeDatos.Update(Data, table);


    }
    public bool Eliminar(int valor)
    {
        Conectar(table);
        DataRow fila;
        int x = Data.Tables[table].Rows.Count - 1;
        for (int i = 0; i < x; i++)
        {
            fila = Data.Tables[table].Rows[i];

            if(int.Parse(fila["idcliente"].ToString())== valor)
            {
                fila = Data.Tables[table].Rows[i];
                fila.Delete();
                DataTable tablaborrados;
                tablaborrados = Data.Tables[table].GetChanges(DataRowState.Deleted);
                adaptadorDeDatos.Update(tablaborrados);
                Data.Tables[table].AcceptChanges();
                return true;
            }
        }

        return false;
    }

    public bool Existe(int valor)
    {
        Conectar(table);
        DataRow fila;
        int x = Data.Tables[table].Rows.Count - 1;
        for(int i = 0; i <= x;i++)
        {
            fila = Data.Tables[table].Rows[i];
            if(int.Parse(fila["idcliente"].ToString())== valor)
            {
                Idcliente = int.Parse(fila["idcliente"].ToString());
                Nombre = fila["nombre"].ToString();
                Direccion = fila["direccion"].ToString();
                Telefono = fila["telefono"].ToString();
                return true;
            }
          
        }
        return false;

    }

}