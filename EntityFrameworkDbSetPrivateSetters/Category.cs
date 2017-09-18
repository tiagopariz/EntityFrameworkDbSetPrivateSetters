/// <summary>
/// Construtor padrão explícito: Não
/// Construtor recebendo todas as propriedades: Não
/// Construtor recebendo todas as propriedades, menos Id: Não
/// Propriedades com set: Private (Implícito)
/// Migrations: Não
/// </summary>
namespace EntityFrameworkDbSetPrivateSetters
{
    public class Category
    {
        public int CategoryId { get; }
        public string Name { get; }
    }
}