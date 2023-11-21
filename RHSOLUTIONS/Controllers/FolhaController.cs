using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMIVRH.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PIMIVRH.Controllers
{
    public class FolhaController : Controller
    {
        public IActionResult Index()
        {
            FolhaModel folha = GerarFolha();
            return View(folha);
        }
        public FolhaModel GerarFolha()
        {
            var conexaoSql = @"Data Source=DESKTOP-8UUI7PR\SQLEXPRESS2022;Initial Catalog=RHSOLUTIONS;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);

            FolhaModel folha = new FolhaModel();

            var NCpf = HttpContext.Session.GetString("Cpf");
            conexaoDB.Open();

            string query = $"SELECT Nome, TelefoneFunc, CargoFunc, SalarioFunc, VAuxilioAlimentacao, VAuxilioRefeicao, Email, ValeTransporte "+
                           $"from FUNCIONARIO WHERE Cpf = '{NCpf}'";

            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                folha.Nome = reader.GetString(0);
                folha.Telefone = reader.GetString(1);
                folha.Cargo = reader.GetString(2);
                folha.Salario = reader.GetDouble(3);
                folha.VAuxilioAlim = reader.GetDouble(4);
                folha.VAuxilioRef = reader.GetDouble(5);
                folha.Email = reader.GetString(6);
                folha.ValeTransporte = reader.GetString(7);
                folha.Cpf = NCpf;

            }

            double descontoIR = CalculoImpostoDeRenda(folha);
            double descontoInss = CalculoInss(folha);
            double descontoVt = CalculoValeTransporte(folha);

            double salarioLiquido = folha.Salario - (descontoInss + descontoIR + descontoVt);
            ViewBag.salarioLiquido = $"{salarioLiquido}";
            conexaoDB.Close();

            return folha;

                
        }

        public double CalculoImpostoDeRenda(FolhaModel model)
        {
            double valorDesconto;
            double inicioFaixa = 2112.00;
            double faixaUm = 2826.66;
            double faixaDois = 3751.05;
            double faixaTres = 4664.68;

            double[] aliquotas = { 0.075, 0.15, 0.225, 0.275 };
            double[] deducao = { 158.40, 370.40, 651.73, 884.96 };
            
            if(model.Salario >= inicioFaixa && model.Salario < faixaUm)
            {
                valorDesconto = (model.Salario * aliquotas[0]) - deducao[0];
                return valorDesconto;
            }
            else if(model.Salario >= faixaUm && model.Salario < faixaDois)
            {
                valorDesconto = (model.Salario * aliquotas[1]) - deducao[1];
                return valorDesconto;
            }
            else if (model.Salario >= faixaDois && model.Salario < faixaTres)
            {
                valorDesconto = (model.Salario * aliquotas[2]) - deducao[2];
                return valorDesconto;
            }
            else if (model.Salario >= faixaTres)
            {
                valorDesconto = (model.Salario * aliquotas[3]) - deducao[3];
                return valorDesconto;
            }
            return 0.0;
        }

        public double CalculoInss(FolhaModel model)
        {
            double valorDesconto;
            double inicioFaixa = 1320.00;
            double faixaUm = 2571.29;
            double faixaDois = 3856.94;
            double faixaTres = 7507.49;

            double[] aliquotas = { 0.075, 0.09, 0.12, 0.14 };
            

            if (model.Salario >= inicioFaixa && model.Salario < faixaUm)
            {
                valorDesconto = model.Salario * aliquotas[0];
                return valorDesconto;
            }
            else if (model.Salario >= faixaUm && model.Salario < faixaDois)
            {
                valorDesconto = model.Salario * aliquotas[1]; 
                return valorDesconto;
            }
            else if (model.Salario >= faixaDois && model.Salario < faixaTres)
            {
                valorDesconto = model.Salario * aliquotas[2];
                return valorDesconto;
            }
            else if (model.Salario >= faixaTres)
            {
                valorDesconto = model.Salario * aliquotas[3];
                return valorDesconto;
            }
            return 0.0;
        }

        public double CalculoValeTransporte(FolhaModel model)
        {
            if(model.ValeTransporte == "S")
            {
                var descontoVT = model.Salario * 0.06;
                return descontoVT;
            }
            return 0.0;
            
        }
    }
}
