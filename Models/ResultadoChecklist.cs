namespace API_LOGISTICA_EF_NET.Models;
public class ResultadoChecklist
{
    public int Id { get; set; }
    public int IdMaquina { get; set; }
    public int IdChecklist { get; set; }
    public DateTime Fecha { get; set; }
    public int IdMaquinista { get; set; }
}