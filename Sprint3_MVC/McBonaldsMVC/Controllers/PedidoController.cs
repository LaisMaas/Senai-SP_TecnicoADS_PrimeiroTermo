using System;
using McBonaldsMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            shake.Nome =form["shake"];
            shake.Preco = 0.0;      
            //return View("Sucesso");

            pedido.Shake = shake;

            Hamburger hamburguer = new Hamburguer (form["hamburguer"],0.0);

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()

            {
                Nome = form["nome"],
                Endereco =form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataPedido = DateTime.Now;


        }
    }
}