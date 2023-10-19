using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIMIVRH.Interfaces;
using PIMIVRH.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PIMIVRH.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<FuncionarioModel> listaPonto = listarHome();
            return View(listaPonto);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public List<FuncionarioModel> listarHome()
        {
            var conexaoSql = @"Data Source=DESKTOP-8UUI7PR\SQLEXPRESS2022;Initial Catalog=RHSOLUTIONS;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            FuncionarioModel Home = new FuncionarioModel();

            
            List<FuncionarioModel> lista = new List<FuncionarioModel>();


            var NFuncional = HttpContext.Session.GetString("Funcional");


            conexaoDB.Open();

            string query = $"SELECT * FROM FUNCIONARIO AS A FULL JOIN ENDERECOFUNC AS B ON A.Cpf = B.Cpf WHERE Funcional = '{NFuncional}'";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Home.Cpf = reader.GetString(0);
                HttpContext.Session.SetString("Cpf", Home.Cpf);
                Home.Nome = reader.GetString(1);
                Home.Telefone = reader.GetString(2);
                Home.CargoFunc = reader.GetString(3);
                Home.SalarioFunc = reader.GetDouble(4);
                Home.VAuxilioAlimentacao = reader.GetDouble(6);
                Home.VAuxilioRefeicao = reader.GetDouble(7);
                Home.Email = reader.GetString(9);
                Home.Endereco = reader.GetString(13);
                Home.Numero = reader.GetInt32(14);
                Home.Complemento = reader.GetString(15);
                Home.Cidade = reader.GetString(16);
                Home.Cep = reader.GetString(17);

                lista.Add(Home);
            }

            return lista;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
