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
using CheckList.ResquestModel.CheckListItem;
using CheckList.ViewModel.CheckList;
using CheckList.ViewModel.CheckListItem;
using AdicionarViewModel = CheckList.ViewModel.CheckListItem.AdicionarViewModel;
using EditarViewModel = CheckList.ViewModel.CheckListItem.EditarViewModel;
using ListagemViewModel = CheckList.ViewModel.CheckListItem.ListagemViewModel;
using RemoverViewModel = CheckList.ViewModel.CheckListItem.RemoverViewModel;

namespace CheckList.Controllers
{
    public class CheckListItemController : Controller
    {
        private readonly ILogger<CheckListItemController> _logger;
        private readonly CheckListItemService _checkListItemService;
        private readonly CheckListService _checkListService;

        public CheckListItemController(ILogger<CheckListItemController> logger, CheckListItemService checkListItemService, CheckListService checkListService)
        {
            _logger = logger;
            _checkListItemService = checkListItemService;
            _checkListService = checkListService;
        }

        [HttpGet] //mandar pra tela
        public IActionResult Listagem(int id)
        {
            var viewModel = new ListagemViewModel()
            {
                msgSucesso = (string) TempData["formMsgSucesso"],
                msgErro = (string[])TempData["formMsgErros"]
            };
            
            var listaCheckListItem = _checkListItemService.ObterPorCheckList(id);
            
            foreach ( CheckListItemEntity checkListItemEntity in listaCheckListItem)
            {
                viewModel.Itens.Add(new Itens()
                {
                    id = checkListItemEntity.id.ToString(),
                    realizado= checkListItemEntity.realizado,
                    titulo = checkListItemEntity.titulo,
                    subItem = checkListItemEntity.checklistItemId.ToString()
                });
                
            }
            
            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult Adicionar(int id) //mostrar para o usuario
        {  
            var viewModel = new AdicionarViewModel()
            {
                 msgErros= (string[]) TempData["formMsgErros"],
            };

            var listaItem = _checkListItemService.ObterTodo();
            foreach ( CheckListItemEntity checkListItemEntity in listaItem)
            {
                viewModel.Itens.Add(new Itens()
                {
                    id = checkListItemEntity.id.ToString(),
                    titulo = checkListItemEntity.titulo
                });
                
            }
            
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
        
        [HttpPost]
        public RedirectResult Adicionar(AdicionarResquestModel requestModel)
        {

            var listaErros = requestModel.ValidarEFiltrar();

            if (listaErros.Count > 0)
            {
                TempData["formMsgErro"] = listaErros;

                return Redirect("/CheckListItem/Adicionar");
            }

            try
            {
                _checkListItemService.Adicionar(requestModel);
                TempData["formMsgSucesso"] = "Item adicionado com sucesso!!";

                string rota = "/CheckListItem/Listagem/" + requestModel.checklistId;
                return Redirect(rota);
            }
            catch (Exception e)
            {

                TempData["formMsgErros"] = new List<string> {e.Message};
                
                return Redirect("/CheckListItem/Adicionar");
            }

        }
        
        [HttpGet]
        public IActionResult Editar(int id)
        {
            try
            {
                var entidadeAEditar = _checkListItemService.ObterPorId(id);
                
                var viewModel = new EditarViewModel()
                {
                    msgErros = (string[]) TempData["formMsgErros"],
                    id = entidadeAEditar.id.ToString(),
                    titulo = entidadeAEditar.titulo,
                    realizado = entidadeAEditar.realizado,
                    checklistId = entidadeAEditar.checklistId.ToString(),
                    checklistItemId = entidadeAEditar.checklistItemId.ToString(),
                    dataRealizacao = entidadeAEditar.dataRealizacao
                    
                };
                
                var listaItem = _checkListItemService.ObterTodo();
                foreach ( CheckListItemEntity checkListItemEntity in listaItem)
                {
                    viewModel.Itens.Add(new Itens()
                    {
                        id = checkListItemEntity.id.ToString(),
                        titulo = checkListItemEntity.titulo
                    });
                
                }
                
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
            catch (Exception e)
            {
               
                TempData["formMsgErros"] = new List<string> { e.Message };

                return Redirect( "/CheckListItem/Listagem");
            }            
        }
        
        [HttpPost]
        public RedirectResult Editar(int id, EditarRequestModel requestModel)
        {

            var listaErros = requestModel.ValidarEFiltrar();
            
            if (listaErros.Count > 0)
            {
                TempData["formMsgErro"] = listaErros;

                return Redirect("/CheckListItem/Editar");
            }
            try
            {
                _checkListItemService.Editar(id ,requestModel);
                TempData["formMsgSucesso"] = "Item editado com sucesso!!";
                
                string rota = "/CheckListItem/Listagem/" + requestModel.checklistId;
                
                return Redirect( rota);
            }
            catch (Exception exception)
            {

                TempData["formMsgErros"] = new List<string> { exception.Message };
                
                return Redirect("/CheckListItem/Editar");
            }
        }
        
        [HttpGet]
        public IActionResult Remover(int id)
        {
            try
            {
                var entidadeARemover = _checkListItemService.ObterPorId(id);
                var viewModel = new RemoverViewModel()
                {
                    msgErros = (string[]) TempData["formMsgErros"],
                    id = entidadeARemover.id.ToString(),
                    titulo = entidadeARemover.titulo,
                    realizado = entidadeARemover.realizado,
                    checklistId = entidadeARemover.checklistId.ToString(),
                    checklistItemId = entidadeARemover.checklistItemId.ToString(),
                    dataRealizacao = entidadeARemover.dataRealizacao
                    
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                TempData["formMsgErros"] = new List<string> { e.Message };

                return Redirect( "/CheckListItem/Listagem");
            }            
        }

        [HttpPost]
        public RedirectResult Remover(int id, object requestModel)
        {
            try
            {
                _checkListItemService.Remover(id);
                TempData["formMsgSucesso"] = "Item removido com sucesso!!";
                
                return Redirect( "/CheckList/Listagem");
            }
            
            catch (Exception exception)
            {
                TempData["formMsgErros"] = new List<string> {exception.Message};

                return Redirect("Remover");
            }

        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}