namespace Formulario.Models
{
    public class FormularioEntity
    {
        public int Id { get; set; }
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public string? ConfirmarSenha { get; set; }
        public string? NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? Rg {  get; set; }
        public string? Cpf { get; set; }
        public string? Sexo { get; set; }
        public bool TermosAceitos { get; set; }
        public bool Notificacoes { get; set; }

    }
}
