using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Models;
using RoleTop.Repositories;

namespace RoleTop.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(form["nome"],form["senha"],form["email"],form["cpf"],DateTime.Parse(form["dataNascimento"]),form["telefone"]);
                clienteRepository.Inserir(cliente);

                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}