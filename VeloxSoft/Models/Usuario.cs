namespace VeloxSoft.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public bool Secion { get; set; }
        public bool Estado { get; set; }
    }
}
