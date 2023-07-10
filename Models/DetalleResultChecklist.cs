namespace API_LOGISTICA_EF_NET.Models; public class DetalleResultChecklist
{
    public int Id { get; set; }
    public int IdResultChkl { get; set; }
    public int IdItemChkl { get; set; }
    public string Valor { get; set; }
}