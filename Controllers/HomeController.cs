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
        Cliente cliente1 = new Cliente(01, "Edvania Bezerra Silva", "321.432.567-00", "edva.silva@gmail.com", "Ringo");
        Cliente cliente2 = new Cliente(02, "Lucas kaua Castro", "567.876.098-99", "lucas.castro@gmail.com", "Pingo");
        Cliente cliente3 = new Cliente(03, "Maressa Giovanna Castro", "111.222.33-11", "maressa.castro@gmail.com", "Xuxinha");
        Cliente cliente4 = new Cliente(04, "Queren Happouch Castro", "426.859.009-34", "queren.castro@gmail.com", "Lupita");
        Cliente cliente5 = new Cliente(05, "Herby Henrique Castro", "646.876.981-77", "henrique.castro@gmail.com", "Vick");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "CastroPet", "321.432.0001-56", "castropet.silva@gmail.com");
         Fornecedor fornecedor2 = new Fornecedor(02, "linsPet", "567.444.0001-89", "linspet.silva@gmail.com");
         Fornecedor fornecedor3 = new Fornecedor(03, "SantanaPet", "111.456.0001-35", "santanapet.silva@gmail.com");
         Fornecedor fornecedor4 = new Fornecedor(04, "silvaPet", "564.687.0001-10", "silvapet.silva@gmail.com");
         Fornecedor fornecedor5 = new Fornecedor(05, "SoutoPet", "568.999.0001-58", "soutopet.silva@gmail.com");


        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        /* O Viewbag funciona como uma "bolsa" para os dados. Com esse recurso 
        você consegue envia os dados para as views. No código abaixo a listaFornecedores 
        está sendo preparada para ser usada na View que vai exxibir os dados. */
        ViewBag.listaFornecedores = listaFornecedores;



        /* A linha abaixo vem por default nessa função. Ela retorna 
        para a view com todas as informações que enviamos. */
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
