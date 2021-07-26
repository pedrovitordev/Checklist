using System.Collections;
using System.Collections.Generic;
using CheckList.Models.CheckList;

namespace CheckList.ViewModel.CheckList
{
    public class AdicionarViewModel 
    {
        public string id { get; set; }
        public string Nome { get; set; }
        
       public string[] msgErros { get; set; } 
        
       
    }
}