public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _DataRetirada;
    private int _QuantidadedeDias;
    private decimal _ValorDiaria;
    
    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um cliente."
                );
            }

            _cliente = value;
        }
        
    }

    public Veiculo Veiculo
    {
        get
        {
            return _veiculo;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um veículo."
                );
            }

            _veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get
        {
            return _DataRetirada;
        }

        private set
        {
            _DataRetirada = value;
        }
    }

    public int QuantidadedeDias
    {
        get
        {
            return _QuantidadedeDias;
        }

        set
        {
            _QuantidadedeDias = value;
        }
    }

      public decimal ValorDiaria
    {
        get
        {
            return _ValorDiaria;
        }

        set
        {
            _ValorDiaria = value;
        }
    }

    public Locacao(
        Cliente cliente,
        Veiculo veiculo,
        DateOnly dataRetirada,
        int quantidadedeDias,
        decimal valorDiaria
    )

    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadedeDias = quantidadedeDias;
        ValorDiaria = valorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        return QuantidadedeDias * ValorDiaria;
    }

    public decimal CalcularDesconto()
    {
        if (QuantidadedeDias >= 7 && QuantidadedeDias <= 14)
        {
            return CalcularValorBruto() * 0.1m;
        }

        else if(QuantidadedeDias >= 15)
        {
            return CalcularValorBruto() * 0.15m;
        }

        else
        {
            return 0m;
        }
    }

    public decimal CalcularValorFinal()
    {
        return CalcularValorBruto() - CalcularDesconto(); 
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"----- LOCAÇÃO DE VEÍCULOS -----");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Modelo do veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Placa do veículo: {Veiculo.Placa}");
        Console.WriteLine($"Data de retirada: {DataRetirada}");
        Console.WriteLine($"Quantidade de dias: {QuantidadedeDias}");
        Console.WriteLine($"Valor da diária: {ValorDiaria}");
        Console.WriteLine($"Valor bruto: {CalcularValorBruto()}");
        Console.WriteLine($"Desconto: {CalcularDesconto()}"); 
        Console.WriteLine($"Valor Final: {CalcularValorFinal()}");         
    }
}