using Microsoft.AspNetCore.Mvc;
using PIMIVRH.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PIMIVRH.Controllers
{
    public class PontoController : Controller
    {
        public IActionResult Index()
        {
            List<PontoModel> listaPonto = ListarPontoEletronico();
            return View(listaPonto);
        }

        public List<PontoModel> ListarPontoEletronico()
        {
            var conexaoSql = @"Data Source=DESKTOP-8UUI7PR\SQLEXPRESS;Initial Catalog=DBRH;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            PontoModel ponto = new PontoModel();

            List<PontoModel> lista = new List<PontoModel>();


            conexaoDB.Open();

            string query = "SELECT * FROM PONTO";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ponto.PrimeiraBatida = reader.GetDateTime(0);
                ponto.SegundaBatida = reader.GetDateTime(1);
                ponto.TerceiraBatida = reader.GetDateTime(2);
                ponto.QuartaBatida = reader.GetDateTime(3);
                ponto.HorasTrabalhadas = reader.GetInt32(4);
                ponto.Cpf = reader.GetString(5);

                lista.Add(ponto);
            }

            return lista;
        }
    }
}
