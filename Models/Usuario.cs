namespace API_LOGISTICA_EF_NET.Models;
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool? Allowed { get; set; }
    public string ResetToken { get; set; }
    public bool? IsAdmin { get; set; }
}