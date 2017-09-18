/// <summary>
/// Construtor padrão explícito: Não
/// Construtor recebendo todas as propriedades: Não
/// Construtor recebendo todas as propriedades, menos Id: Public
/// Propriedades com set: Private
/// Migrations: Sim
/// </summary>
namespace EntityFrameworkDbSetPrivateSetters
{
    public class State
    {
        public State(string name)
        {
            Name = name;
        }

        public int StateId { get; private set; }
        public string Name { get; private set; }
    }
}