public class Veiculo
{
    private string modelo;
    private string placa;

    public string Modelo
    {
        get
        {
            return modelo;
        }

        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O modelo do veículo não pode ficar vazio."
                );
            }

            modelo = value.Trim();
        }
    }

    public string Placa
    {
        get
        {
            return placa;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa do veículo não pde ficar vazia"
                );
            }

            placa = value.Trim();
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Placa = placa;
        Modelo = modelo;
    }

       public void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Modelo: {Modelo}");
    }

}