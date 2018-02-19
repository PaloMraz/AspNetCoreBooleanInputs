using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreBooleanInputs.Models;
using System.Text;

namespace AspNetCoreBooleanInputs.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var model = new BooleanInputsViewModel();
      model.Messages.Add($"GET values: {nameof(model.IsImportant)} = {model.IsImportant}, {nameof(model.IsActive)} = {model.IsActive}");
      return View(model);
    }


    [HttpPost]
    public IActionResult Index(BooleanInputsViewModel model)
    {
      model.Messages.Add($"POST values: {nameof(model.IsImportant)} = {model.IsImportant}, {nameof(model.IsActive)} = {model.IsActive}");

      model.IsActive = !model.IsActive;
      model.IsImportant = !model.IsImportant;
      
      model.Messages.Add($"Negated POST values: {nameof(model.IsImportant)} = {model.IsImportant}, {nameof(model.IsActive)} = {model.IsActive}");
      return this.View(model);
    }


    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
