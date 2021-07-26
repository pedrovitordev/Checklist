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
using CheckList.ResquestModel.CheckList;
using CheckList.ViewModel.CheckList;


namespace CheckList.Controllers
{
    public class CheckListController : Controller
    {
        private readonly ILogger<CheckListController> _logger;
        private readonly CheckListService _checkListService;

        public CheckListController(ILogger<CheckListController> logger, CheckListService checkListService)
        {
            _logger = logger;
            _checkListService = checkListService;
        }

        public IActionResult Listagem() //listagem
        {
            var viewModel = new ListagemViewModel()
            {
                msgSucesso = (string)TempData["formMsgSucesso"],
                msgErro = (string[])TempData["formMsgErros"]
            };

            var listaCheckList = _checkListService.ObterTodo();
            
            foreach ( CheckListEntity checkListEntity in listaCheckList)
            {
                viewModel.CheckLists.Add(new CheckLists()
                {
                    id = checkListEntity.id.ToString(),
                    nome = checkListEntity.nome
                });
                
            }

            return View(viewModel);
        }
        
        [HttpGet] //mostrar para o usuario o formulario
        public IActionResult Adicionar()
        {  
            var viewModel = new AdicionarViewModel()
            {
                msgErros = (string[]) TempData["formMsgErros"]
            };
            
            return View(viewModel);
        }
        
        [HttpPost] //processar o formulario enviado para o usuario
        public RedirectToActionResult Adicionar(AdicionarRequestModel requestModel)
        {
            var nome = requestModel.Nome;
            
            var listaErros = requestModel.ValidarEFiltrar();

            if (listaErros.Count > 0)
            {
                TempData["formMsgErro"] = listaErros;

                return RedirectToAction("Adicionar");
            }

            try
            {
                _checkListService.Adicionar(requestModel);
                TempData["formMsgSucesso"] = "Checklist adicionada com sucesso!!";

               
                return RedirectToAction("Listagem");
            }
            catch (Exception e)
            {

                TempData["formMsgErros"] = new List<string> {e.Message};
                
                return RedirectToAction("Adicionar");
            }

        }
        
        [HttpGet]
        public IActionResult Editar(int id)
        {
            try
            {
                var entidadeAEditar = _checkListService.ObterPorId(id);
                
                var viewModel = new EditarViewModel()
                {
                    msgErros = (string[]) TempData["formMsgErros"],
                    id = entidadeAEditar.id.ToString(),
                    Nome = entidadeAEditar.nome
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                TempData["formMsgErros"] = new List<string> { e.Message };

                return RedirectToAction("Listagem");
            }            
        }
        
        [HttpPost]
        public RedirectToActionResult Editar(int id, EditarRequestModel requestModel)
        {
            Console.WriteLine(id);
            var listaErros = requestModel.ValidarEFiltrar();
            
            if (listaErros.Count > 0)
            {
                TempData["formMsgErro"] = listaErros;

                return RedirectToAction("Editar");
            }
            try
            {
                _checkListService.Editar(id ,requestModel);
                TempData["formMsgSucesso"] = "CheckList editados com sucesso.";
                
                return RedirectToAction("Listagem");
            }
            catch (Exception exception)
            {

                TempData["formMsgErros"] = new List<string> { exception.Message };
                
                return RedirectToAction("Editar");
            }
        }
        
        public IActionResult Remover(int id)
        {
            try
            {
                var entidadeARemover = _checkListService.ObterPorId(id); //uma variavel que pega o id que o usuario escolheu para remover
                var viewModel = new RemoverViewModel()
                {
                    msgErros = (string[]) TempData["formMsgErros"],
                    id = entidadeARemover.id.ToString(),
                    Nome = entidadeARemover.nome
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                TempData["formMsgErros"] = new List<string> { e.Message };

                return RedirectToAction("Listagem");
            }            
        }

        [HttpPost]
        public RedirectToActionResult Remover(int id, object requestModel)
        {
            try
            {
                _checkListService.Remover(id);
                TempData["formMsgSucesso"] = "CheckList removido com sucesso!!";

                return RedirectToAction("Listagem");
            }
            catch (Exception exception)
            {

                TempData["formMsgErros"] = new List<string> {exception.Message};

                return RedirectToAction("Remover");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}