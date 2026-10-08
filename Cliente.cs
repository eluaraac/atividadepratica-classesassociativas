public class Cliente
{
    private string nome;
    private string cpf;

    public string Nome
    {
        get
        {
           return nome; 
        }

        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome do cliente não pode ficar vazio."
                );

            }

            nome = value.Trim();
        }
    }

    public string Cpf
    {
        get
        {
           return cpf; 
        }

        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O CPF do cliente não pode ficar vazio."
                );

            }

            cpf = value.Trim();
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"Cpf: {Cpf}");
    }

    
}

