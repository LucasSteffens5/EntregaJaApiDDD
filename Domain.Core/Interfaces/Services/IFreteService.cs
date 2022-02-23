namespace Domain.Core.Interfaces.Services
{
    public interface IFreteService
    {
        decimal CalcularFrete(string cep);

        void ValidarCep(string cep);

        bool EhRioDeJaneiroCapital(string cep);

        bool EhRioDeJaneiroRegiaoMetropolitana(string cep);

        bool EhRioDeJaneiroInterior(string cep);

        string RetornarApenasDigitos(string cep);
    }
}
