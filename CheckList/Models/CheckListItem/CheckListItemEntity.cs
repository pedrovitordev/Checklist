namespace CheckList.Models.CheckListItem
{
    public class CheckListItemEntity
    {
        public int id { get; set; }

        public int checklistId { get; set; }

        public int checklistItemId { get; set; }

        public string titulo { get; set; }

        public string realizado { get; set; }

        public string dataRealizacao { get; set; }

        public CheckListItemEntity()
        {
        }

        public CheckListItemEntity(int id, int checklistId, int checklistItemId, string titulo, string realizado, string dataRealizacao)
        {
            this.id = id;
            this.checklistId = checklistId;
            this.checklistItemId = checklistItemId;
            this.titulo = titulo;
            this.realizado = realizado;
            this.dataRealizacao = dataRealizacao;
        }
        
        
    }
}