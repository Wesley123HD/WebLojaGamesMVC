using WebLojaGamesMVC.Repositorio;
using WebLojaGamesMVC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLojaGamesMVC.Repositorio
{
    public class AcoesFunc
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.FuncNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbFunc values(@FuncCod,@FuncNome," +
                "@FuncCPF, @FuncRG, @FuncNasc, @FuncCEP, @FuncCel, @FuncEmail, @FuncCargo,)",
                con.ConectarBD());
            cmd.Parameters.Add("@FuncCod", MySqlDbType.Int16).Value = func.FuncCod;
            cmd.Parameters.Add("@FuncNome", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@FuncCPF", MySqlDbType.VarChar).Value = func.FuncCPF;
            cmd.Parameters.Add("@FuncRG", MySqlDbType.VarChar).Value = func.FuncRG;
            cmd.Parameters.Add("@FuncNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@FuncCEP", MySqlDbType.VarChar).Value = func.FuncCEP;
            cmd.Parameters.Add("@FuncCel", MySqlDbType.VarChar).Value = func.FuncCel;
            cmd.Parameters.Add("@FuncEmail", MySqlDbType.VarChar).Value = func.FuncEmail;
            cmd.Parameters.Add("@FuncCargo", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
    }
}