using Microsoft.AspNetCore.Mvc;
using PIMIVRH.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PIMIVRH.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ValidaUsuario(LoginModel login)
        {
            if (Validacao(login))
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
        protected bool Validacao(LoginModel login)
        {
            var conexaoSql = @"Data Source=DESKTOP-8UUI7PR\SQLEXPRESS;Initial Catalog=DBRH;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);

            conexaoDB.Open();

            if(login.Funcional == null  || login.Senha == null)
            {
                TempData["MensagemErro"] = "Não foi possivel fazer o login funcional ou senha incorretos";
                return false;
            }
            

            string query = $"SELECT Funcional, Senha FROM FUNCIONARIOS WHERE Funcional = {login.Funcional} AND Senha = {login.Senha}";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                
                TempData["MensagemErro"] = "Não foi possivel fazer o login funcional ou senha incorretos";
                return false;
                
            }
            else
            {
                
            return true;
            }
        }
    }
}
