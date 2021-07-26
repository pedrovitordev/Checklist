using System;
using System.Collections.Generic;
using System.Linq;
using CheckList.Data;
using CheckList.Models.CheckListItem;

namespace CheckList.Models.CheckList
{
    public class CheckListService
    {
         private readonly DatabaseContext _databaseContext;
         private readonly CheckListItemService _checkListItemService;


         public CheckListService(DatabaseContext databaseContext, CheckListItemService checkListItemService)
         {
             _databaseContext = databaseContext;
             _checkListItemService = checkListItemService;
         }

         public ICollection<CheckListEntity> ObterTodo()
         {
             return _databaseContext.CheckList.ToList();
         }

         public int todosCheckList()
         {
             return _databaseContext.CheckList.Count();
         }
         
         public CheckListEntity ObterPorId(int id)
         {
             try
             {
                 return _databaseContext.CheckList.Find(id);
             }
             catch
             {
                 throw new Exception("CheckList de ID #" + id + "não encontrado");
             }
         }
         
         public CheckListEntity Adicionar(IDadosBasicoCheckListModel dadosBasicos)
         {
             var novaentidade = ValidarDadosBasico(dadosBasicos);
             _databaseContext.CheckList.Add(novaentidade);
             _databaseContext.SaveChanges();


             return novaentidade;
         }
         
         public CheckListEntity Editar(
             int id,
             IDadosBasicoCheckListModel dadosBasico)
         {
             var entidadeEditar = ObterPorId(id);
             entidadeEditar = ValidarDadosBasico(dadosBasico, entidadeEditar);
             _databaseContext.SaveChanges();

             return entidadeEditar;

         }
         
         public bool Remover(int id)
         {
             var entidadeARemover = ObterPorId(id);
             _databaseContext.CheckList.Remove(entidadeARemover);
             _databaseContext.SaveChanges();

             var listaitens = _checkListItemService.ObterPorCheckList(id);
             
             foreach ( CheckListItemEntity checkListItemEntity in listaitens)
             {
                 _checkListItemService.Remover(checkListItemEntity.id);

             }
             return true;
         }

         private CheckListEntity ValidarDadosBasico(
             IDadosBasicoCheckListModel dadosBasicos,
             CheckListEntity entidadeExistente = null)
         {
             var entidade = entidadeExistente ?? new CheckListEntity();

             if (dadosBasicos.Nome == null)
             {
                 throw new Exception("O Nome é obrigatorio");
             }
             
             entidade.nome = dadosBasicos.Nome;
             
             
             return entidade;
         }

         public interface IDadosBasicoCheckListModel
         {
             public string id { get; set; }
             public string Nome { get; set; }
            
         }
    }
}