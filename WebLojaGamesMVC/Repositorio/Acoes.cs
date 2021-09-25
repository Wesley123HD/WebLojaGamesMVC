using WebLojaGamesMVC.Models;
using MySql.Data.MySqlClient;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebLojaGamesMVC.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCliente(Cliente cli)
        {
            string data_sistema = Convert.ToDateTime(cli.CliNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbCli values(@CliCoD, @CliCPF, @CliNome, @CliNasc, @CliCEP, @CliCel, @CliEmail)", con.ConectarBD());
            cmd.Parameters.Add("@CliCoD", MySqlDbType.VarChar).Value = cli.CliCod;
            cmd.Parameters.Add("@CliCPF", MySqlDbType.VarChar).Value = cli.CliCPF;
            cmd.Parameters.Add("@CliNome", MySqlDbType.VarChar).Value = cli.CliNome;
            cmd.Parameters.Add("@CliNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@CliCEP", MySqlDbType.VarChar).Value = cli.CliCEP;
            cmd.Parameters.Add("@CliCel", MySqlDbType.VarChar).Value = cli.CliCel;
            cmd.Parameters.Add("@CliEmail", MySqlDbType.VarChar).Value = cli.CliEmail;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCodCliente(int cod)
        {
            var commandCli = String.Format("select * from tbCli where CliCoD = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(commandCli, con.ConectarBD());
            var DadosCodCli = cmd.ExecuteReader();
            return ListarCodCli(DadosCodCli).FirstOrDefault();
        }

        public List<Cliente> ListarCodCli(MySqlDataReader dtCli)
        {
            var AltAlCli = new List<Cliente>();
            while (dtCli.Read())
            {
                var AlTempCli = new Cliente()
                {
                    CliCod = ushort.Parse(dtCli["CliCoD"].ToString()),
                    CliNome = dtCli["CliNome"].ToString(),
                    CliCPF = dtCli["CliCPF"].ToString(),
                    CliNasc = DateTime.Parse(dtCli["CliNasc"].ToString()),
                    CliCEP = dtCli["CliCEP"].ToString(),
                    CliCel = dtCli["CliCel"].ToString(),
                    CliEmail = dtCli["CliEmail"].ToString()

                };
                AltAlCli.Add(AlTempCli);
            }
            dtCli.Close();
            return AltAlCli;
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbCli", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarAllCliente(DadosCliente);
        }

        public List<Cliente> ListarAllCliente(MySqlDataReader dtCli)
        {
            var AllCli = new List<Cliente>();
            while (dtCli.Read())
            {
                var CliTemp = new Cliente()
                {
                    CliCod = ushort.Parse(dtCli["CliCoD"].ToString()),
                    CliNome = dtCli["CliNome"].ToString(),
                    CliCPF = dtCli["CliCPF"].ToString(),
                    CliNasc = DateTime.Parse(dtCli["CliNasc"].ToString()),
                    CliCEP = dtCli["CliCEP"].ToString(),
                    CliCel = dtCli["CliCel"].ToString(),
                    CliEmail = dtCli["CliEmail"].ToString()

                };
                AllCli.Add(CliTemp);
            }
            dtCli.Close();
            return AllCli;
        }

    }
}