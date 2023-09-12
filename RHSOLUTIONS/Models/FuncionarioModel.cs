namespace PIMIVRH.Models
{
    public class FuncionarioModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string CargoFunc { get; set; }
        public string Email { get; set; }
        public double SalarioFunc { get; set; }
        public ResidenciaModel residencia { get; set; }
    }
}
