using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheckList.Models;
using CheckList.Models.CheckList;
using CheckList.Models.CheckListItem;
using CheckList.ViewModel.Home;

namespace CheckList.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CheckListService _checkListService;
        private readonly CheckListItemService _checkListItemService;

        public HomeController(ILogger<HomeController> logger, CheckListService checkListService, CheckListItemService checkListItemService)
        {
            _logger = logger;
            _checkListService = checkListService;
            _checkListItemService = checkListItemService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                totalCheckList = _checkListService.todosCheckList(),
                totalItens = _checkListItemService.todosCheckListItem(),
                itensRealizados = _checkListItemService.todosItemRealizado(),
                itensNaoRealizados = _checkListItemService.todosItemNaoRealizado()
            };
            
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}