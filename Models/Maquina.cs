namespace API_LOGISTICA_EF_NET.Models
{
    public class Maquina
    {
        public int Id { get; set; }
        public int? IdChecklist { get; set; }
        public string IdInterno { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int? IdTipo { get; set; }
    }

}
