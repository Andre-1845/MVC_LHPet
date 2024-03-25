using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1,"Kemell Pinto","123456789-98","pinto@gemail.gom","Buck");
        Cliente cliente2 = new Cliente(2,"Jalin Rabey","111222789-54","rabey@gemail.gom","Nick");
        Cliente cliente3 = new Cliente(3,"Roney Xavier","123455333-00","xavier@arreil.gom","Chico");
        Cliente cliente4 = new Cliente(4,"Julio Verne","123456789-98","verne@gemail.com","Luke");
        Cliente cliente5 = new Cliente(5,"Mario Costa","123455552-21","bom@bril.com","Teco");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor forn1 = new Fornecedor(1,"TudoPet", "12123123/0001-85", "tudopet@meumeail.com");
        Fornecedor forn2 = new Fornecedor(2,"Pet Calm", "88856313/0001-64", "arrg@teumeail.com");
        Fornecedor forn3 = new Fornecedor(3,"Armazem", "12123123/0001-70", "meuca@semmeail.com");
        Fornecedor forn4 = new Fornecedor(4,"Ceu Azul", "52147823/0001-12" , "tomat@troceail.com");
        Fornecedor forn5 = new Fornecedor(5,"Fazendinha", "96583123/0001-52", "fazend@aleatail.com");

        List<Fornecedor> listaForn = new List<Fornecedor>();
        listaForn.Add(forn1);
        listaForn.Add(forn2);
        listaForn.Add(forn3);
        listaForn.Add(forn4);
        listaForn.Add(forn5);

        ViewBag.listaForn = listaForn;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
