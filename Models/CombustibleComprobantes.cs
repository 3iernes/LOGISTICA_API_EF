namespace API_LOGISTICA_EF_NET.Models
{
    public class CombustibleComprobantes
    {
        public int Id { get; set; }
        public int? IdCargaCombustible { get; set; }
        public byte[] Ticket { get; set; }
    }
}
