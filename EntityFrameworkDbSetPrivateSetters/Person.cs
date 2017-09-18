/// <summary>
/// Construtor padrão explícito: Protected
/// Construtor recebendo todas as propriedades: Public
/// Construtor recebendo todas as propriedades, menos Id: Não
/// Propriedades com set: protected
/// Migrations: Sim
/// </summary>

using System.IO;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class Person
    {
        protected Person() { }

        public Person(int personId,
                      string name,
                      string city,
                      short type)
        {
            PersonId = personId;
            Name = name;
            City = city;
            Type = type;
        }

        public int PersonId { get; protected set; }
        public string Name { get; protected set; }
        public string City { get; protected set; }
        public short Type { get; protected set; }

        public virtual IDocument GetDocument(string number)
        {
            IDocument doc = null;

            switch (Type)
            {
                case 1:
                    doc = new Cpf(number, "CPF");
                    return doc;
                case 2:
                    doc = new Cpf(number, "CNPJ");
                    return doc;
            }

            return doc;
        }

        public virtual string GetProfileUrl(string url)
        {
            return "profile";
        }

    }

    public interface IDocument
    {
        string Number { get; }
        string Type { get; }
    }

    public class Cpf : IDocument
    {
        public Cpf(string number, string type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public string Type { get; private set; }
    }

    public class Cnpj : IDocument
    {
        public Cnpj(string number, string type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public string Type { get; private set; }
    }
}

