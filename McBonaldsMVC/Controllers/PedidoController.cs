using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        public IActionResult Index()
        {

            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.Shakes = shakeRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = ObterUsuarioSession();
            pvm.UsuarioNome = ObterUsuarioNomeSession();
            
            return View(pvm);

        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];
            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = shakeRepository.ObterPrecoDe(nomeShake);

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer();
            hamburguer.Nome = form["hamburguer"];
            hamburguer.Preco = hamburguerRepository.ObterPrecoDe(nomeHamburguer);

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];


            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguerRepository.ObterPrecoDe(nomeHamburguer) + shakeRepository.ObterPrecoDe(nomeShake);
            
            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso");
            } else {
                return View("Erro");
            }

        }
    }
}