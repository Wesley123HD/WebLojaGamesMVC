using WebLojaGamesMVC.Repositorio;
using WebLojaGamesMVC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLojaGamesMVC.Repositorio
{
    public class AcoesJogo
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarJogo(Jogo jogo)
        {
            string data_sistema = Convert.ToDateTime(jogo.JogoAno).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoCod, @JogoNome, " +
                "@JogoDev, @JogoGen, @JogoFaixa, @JogoPlat, @JogoAno, @JogoSinopse)",
                con.ConectarBD());
            cmd.Parameters.Add("@JogoCod", MySqlDbType.Int16).Value = jogo.JogoCod;
            cmd.Parameters.Add("@JogoNome", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("@JogoDev", MySqlDbType.VarChar).Value = jogo.JogoDev;
            cmd.Parameters.Add("@JogoGen", MySqlDbType.VarChar).Value = jogo.JogoGen;
            cmd.Parameters.Add("@JogoFaixa", MySqlDbType.VarChar).Value = jogo.JogoFaixa;
            cmd.Parameters.Add("@JogoPlat", MySqlDbType.VarChar).Value = jogo.JogoPlat;
            cmd.Parameters.Add("@JogoAno", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@JogoSinopse", MySqlDbType.VarChar).Value = jogo.JogoSin;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
    }
}