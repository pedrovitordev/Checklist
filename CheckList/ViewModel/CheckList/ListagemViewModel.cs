using System.Collections.Generic;

namespace CheckList.ViewModel.CheckList
{
    public class ListagemViewModel
    {
        public ICollection<CheckLists> CheckLists { get; set; }

        public string msgSucesso { get; set; }
        
        public string[] msgErro { get; set; }

        public ListagemViewModel()
        {
            CheckLists = new List<CheckLists>();
        }
    }

    public class CheckLists
    {
        public string id { get; set; }

        public string nome { get; set; }
    }
}