/// <summary>
/// Construtor padrão explícito: Não
/// Construtor recebendo todas as propriedades: Public
/// Construtor recebendo todas as propriedades, menos Id: Não
/// Propriedades com set: Private
/// Migrations: Sim
/// </summary>
namespace EntityFrameworkDbSetPrivateSetters
{
    public class City
    {
        public City(int cityId,
                    string name)
        {
            CityId = cityId;
            Name = name;
        }

        public int CityId { get; private set; }
        public string Name { get; private set; }
    }
}