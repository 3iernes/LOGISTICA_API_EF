namespace API_LOGISTICA_EF_NET.Models
{
    public class Chofer
    {
        public int Id { get; set; }
        public int? IdRazonSocial { get; set; }
        public string Cuil { get; set; }
        public string Direccion { get; set; }
        public int? IdLocalidad { get; set; }
        public int? CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? DateRevMedica { get; set; }
        public DateTime? DateCargaGral { get; set; }
        public DateTime? DateCargaPeligrosa { get; set; }
        public DateTime? DateLicConducir { get; set; }
        public DateTime? DateCredPuerto { get; set; }
        public string ApellidoNombre { get; set; }
    }

}
