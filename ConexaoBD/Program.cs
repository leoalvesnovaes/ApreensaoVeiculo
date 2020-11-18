using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOS
{
    class Program
    {
        //static void Main(string[] args)
        //{

            

        //    SqlConnection conexao = new SqlConnection(@"data source=MAQ56\SQLEXPRESS ; Integrated Security=SSPI ; Initial Catalog= ExemploBD ");
        //    conexao.Open();


        //    //string strQueryUpdate = "UPDATE usuarios SET nome = 'LEOO' WHERE  usuarioId = 1";
        //    //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conexao);
        //    //cmdComandoUpdate.ExecuteNonQuery();

        //    //string strQueryDelete = "delete from  usuarios where nome = 'LEOO' ";
        //    //SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conexao);
        //    //cmdComandoDelete.ExecuteNonQuery();

        //    string strQueryInsert = "insert into usuarios values (nome, cargo, date)";
        //    bd.ExecutaComando(strQueryInsert);

        //    string strQuerySelect = "SELECT * FROM USUARIOS";
        //    SqlDataReader dados = bd.ExecutaComandoComRetorno(strQuerySelect);

        //    while (dados.Read())
        //    {
        //        Console.WriteLine("Id:{0}, Nome: {1}, Cargo: {2}, Data: {3}", dados["usuarioId"], dados["nome"], dados["cargo"], dados["date"]);
        //    }
        //}
    }
}
