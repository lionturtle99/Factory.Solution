using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Factory.Models;
using System.Linq;
using System;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Machines = _db.Machines.OrderBy(machine => machine.Name).ToList();
      ViewBag.Engineers = _db.Engineers.OrderBy(engineer => engineer.Name).ToList();
      return View();
    }

  }
}