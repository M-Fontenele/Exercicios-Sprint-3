using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Enums;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class Administrador : AbstractController
    {
        private AgendaRepository AgendaRepository = new AgendaRepository();
        private ClienteRepository clienteRepository = new ClienteRepository();

        public DashboardViewModel DashboardEvento()
        {
            var todosEventos =  AgendaRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach (var item in todosEventos)
            {
                switch(item.Status)
                {
                    case (uint) StatusPedido.APROVADO:
                        dashboardViewModel.EventosAprovados++;
                        break;
                    case (uint) StatusPedido.REPROVADO:
                        dashboardViewModel.EventosReprovados++;
                        break;
                    default:
                        dashboardViewModel.EventosPendentes++;
                        break;
                }
            }
            dashboardViewModel.Agendar = todosEventos;
            dashboardViewModel.NomeView = "Admin";
            dashboardViewModel.UsuarioNome = ObterUsuarioNomeSession();
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();

            return dashboardViewModel;
        }
        public IActionResult Pendentes()
        {
            if(!string.IsNullOrEmpty(ObterUsuarioSession()) && (uint)TiposUsuario.ADIMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var dashboard = DashboardEvento();
                return View(dashboard);
            }
            else
            {
                return View("Erro", new RespostaViewModel("Você não pode acessar essa pagina")
                {
                    NomeView = "Login"
                });
            }
        }
        public IActionResult Aprovados()
        {
            if(!string.IsNullOrEmpty(ObterUsuarioSession()) && (uint)TiposUsuario.ADIMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var dashboard = DashboardEvento();
                return View(dashboard);
            }
            else
            {
                return View("Erro", new RespostaViewModel("Você não pode acessar essa pagina")
                {
                    NomeView = "Login"
                });
            }
        }
        public IActionResult Reprovados()
        {
            if(!string.IsNullOrEmpty(ObterUsuarioSession()) && (uint)TiposUsuario.ADIMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var dashboard = DashboardEvento();
                return View(dashboard);
            }
            else
            {
                return View("Erro", new RespostaViewModel("Você não pode acessar essa pagina")
                {
                    NomeView = "Login"
                });
            }
        }
    }
}