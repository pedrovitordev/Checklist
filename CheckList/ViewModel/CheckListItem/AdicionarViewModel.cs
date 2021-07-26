using System.Collections.Generic;
using CheckList.Models.CheckList;
using CheckList.ViewModel.CheckList;

namespace CheckList.ViewModel.CheckListItem
{
    public class AdicionarViewModel
    {
        public string[] msgErros { get; set; }

        public ICollection<CheckLists> CheckLists { get; set; }

        public ICollection<Itens> Itens { get; set; }

        public AdicionarViewModel()
        {
            CheckLists = new List<CheckLists>();
            Itens = new List<Itens>();
        }
    }
}