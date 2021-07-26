using System.Collections;
using System.Collections.Generic;
using CheckList.Models.CheckListItem;

namespace CheckList.ResquestModel.CheckListItem
{
    public class AdicionarResquestModel : CheckListItemService.IDadosBasicoItemModel
    {
        public string id { get; set; }
        public string checklistId { get; set; }
        public string checklistItemId { get; set; }
        public string titulo { get; set; }
        public string realizado { get; set; }
        public string dataRealizacao { get; set; }
        
        public ICollection ValidarEFiltrar()
        {
            var listaErros = new List<string>();
        
            return listaErros;
        }
    }
}