namespace CheckList.Models.CheckList
{
    public class CheckListEntity
    {
        public int id { get; set; }

        public string nome { get; set; }

        public CheckListEntity()
        {
        }

        public CheckListEntity(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}