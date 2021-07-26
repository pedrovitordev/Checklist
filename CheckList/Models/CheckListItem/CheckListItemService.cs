using System;
using System.Collections.Generic;
using System.Linq;
using CheckList.Data;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Models.CheckListItem
{
    public class CheckListItemService
    {
        private readonly DatabaseContext _databaseContext;

        public CheckListItemService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        
        public int todosCheckListItem()
        {
            return _databaseContext.CheckListItem.Count();
        }
        
        public int todosItemRealizado()
        {
            return _databaseContext.CheckListItem.Count(i=> i.realizado == "Sim");
        }
        
        public int todosItemNaoRealizado()
        {
            return _databaseContext.CheckListItem.Count(i=> i.realizado == "Nao");
        }
        
        public ICollection<CheckListItemEntity> ObterPorCheckList(int id)
        {
            return _databaseContext.CheckListItem.Where(i => i.checklistId == id).ToList();
        }
        
        public ICollection<CheckListItemEntity> ObterTodo()
        {
            return _databaseContext.CheckListItem.ToList();
        }
        
        public CheckListItemEntity ObterPorId(int id)
        {
            try
            {
                return _databaseContext.CheckListItem.Find(id);
            }
            catch
            {
                throw new Exception("Item de ID #" + id + "não encontrado");
            }
        }
        
        public CheckListItemEntity Adicionar(IDadosBasicoItemModel dadosBasicos)
        {
            var novaentidade = ValidarDadosBasico(dadosBasicos);
            _databaseContext.CheckListItem.Add(novaentidade);
            _databaseContext.SaveChanges();
            
            return novaentidade;
        }
        
        public CheckListItemEntity Editar(
            int id,
            IDadosBasicoItemModel dadosBasico)
        {
            var entidadeEditar = ObterPorId(id);
            entidadeEditar = ValidarDadosBasico(dadosBasico, entidadeEditar);
            _databaseContext.SaveChanges();

            return entidadeEditar;

        }
        
        public bool Remover(int id)
        {
            var entidadeARemover = ObterPorId(id);
            _databaseContext.CheckListItem.Remove(entidadeARemover);
            _databaseContext.SaveChanges();

            return true;
        }
        
        private CheckListItemEntity ValidarDadosBasico(
            IDadosBasicoItemModel dadosBasicos,
            CheckListItemEntity entidadeExistente = null)
        {
            var entidade = entidadeExistente ?? new CheckListItemEntity();

            if (dadosBasicos.titulo == null)
            {
                throw new Exception("O Nome é obrigatorio");
            }
             
            entidade.titulo = dadosBasicos.titulo;

            entidade.realizado = dadosBasicos.realizado;
            
            entidade.checklistId = Int32.Parse(dadosBasicos.checklistId);
            
            entidade.checklistItemId = Int32.Parse(dadosBasicos.checklistItemId);

            entidade.dataRealizacao = dadosBasicos.dataRealizacao;
            
            return entidade;
        }
        
        
         public interface IDadosBasicoItemModel
         {
             public string id { get; set; }

             public string checklistId { get; set; }

             public string checklistItemId { get; set; }

             public string titulo { get; set; }

             public string realizado { get; set; }

             public string dataRealizacao { get; set; }
                    
         }
    }

}