using System.Collections.Generic;
using CheckList.Models.CheckListItem;
using CheckList.ViewModel.CheckList;

namespace CheckList.ViewModel.CheckListItem
{
    public class EditarViewModel: CheckListItemService.IDadosBasicoItemModel 
    {
        public string id { get; set; }
        public string checklistId { get; set; }
        public string checklistItemId { get; set; }
        public string titulo { get; set; }
        public string realizado { get; set; }
        public string dataRealizacao { get; set; }
        
        public string[] msgErros { get; set; } 
        
        public ICollection<Itens> Itens { get; set; }
        public ICollection<CheckLists> CheckLists { get; set; }
        
        public EditarViewModel()
        {
            CheckLists = new List<CheckLists>();
            Itens = new List<Itens>();
        }
    }
}