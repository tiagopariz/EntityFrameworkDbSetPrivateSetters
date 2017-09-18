/// <summary>
/// Construtor padrão explícito: Não
/// Construtor recebendo todas as propriedades: Não
/// Construtor recebendo todas as propriedades, menos Id: Não
/// Propriedades com set: Private
/// Migrations: Sim
/// </summary>
namespace EntityFrameworkDbSetPrivateSetters
{
    public class Country
    {
        public int CountryId { get; private set; }
        public string Name { get; private set; }
    }
}