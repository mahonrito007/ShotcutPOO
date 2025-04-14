using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ShotcutPOO.Models;
using Dapper;

namespace ShotcutPOO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string connectionString = @"Server=empresamaho.mssql.somee.com;
                                                      Database=empresamaho;
                                                      User Id=Mahonrito007_SQLLogin_1;
                                                      Password=3s1ug2mpwp;
                                                      TrustServerCertificate=True";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Empleados empleadosQuery)
        {
            IEnumerable<Empleados> usuarios;

            using (var connection = new SqlConnection(connectionString))
            {
                usuarios = connection.Query<Empleados>("select ID,Usuario from DBUsuarios");
            }

            return View(usuarios);
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


        public IActionResult Agregar()
        {
            //agregar un empleado
            return View();
        }

        public IActionResult Eliminar()
        {
            //eliminar un empleado
            return View();
        }

        public IActionResult Editar()
        {
            // editar un empleado
            return View();
        }

    }
}
