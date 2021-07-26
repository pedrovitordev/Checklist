using System.Collections;
using System.Collections.Generic;
using CheckList.Models.CheckList;

namespace CheckList.ResquestModel.CheckList
{
    public class AdicionarRequestModel : CheckListService.IDadosBasicoCheckListModel
    {
        public string id { get; set; }
        public string Nome { get; set; }
        
         public ICollection ValidarEFiltrar()
         {
             var listaErros = new List<string>();
        
             return listaErros;
         }
                
    }
}