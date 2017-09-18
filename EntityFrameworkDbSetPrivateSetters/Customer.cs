/// <summary>
/// Construtor padrão explícito: Private
/// Construtor recebendo todas as propriedades: Public
/// Construtor recebendo todas as propriedades, menos Id: Não
/// Propriedades com set: Private
/// Migrations: Sim
/// </summary>
namespace EntityFrameworkDbSetPrivateSetters
{
    public class Customer
    {
        private Customer() { }

        public Customer(int customerId,
                        string name,
                        string city)
        {
            CustomerId = customerId;
            Name = name;
            City = city;
        }

        public int CustomerId { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
    }
}