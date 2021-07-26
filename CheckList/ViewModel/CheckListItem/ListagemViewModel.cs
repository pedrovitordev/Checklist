using System.Collections.Generic;

namespace CheckList.ViewModel.CheckListItem
{
    public class ListagemViewModel
    {
        public ICollection<Itens> Itens { get; set; }

        public string msgSucesso { get; set; }
        
        public string[] msgErro { get; set; }

        public ListagemViewModel()
        {
            Itens = new List<Itens>();
        }
    }

    public class Itens
    {
        public string id { get; set; }
        public string realizado { get; set; }
        public string titulo { get; set; }
        public string subItem { get; set; }
        
    }
    
}