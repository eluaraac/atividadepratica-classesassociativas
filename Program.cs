Cliente cliente1 = new Cliente(
    "Ana Carolina",
    "12345678912"
);

Cliente cliente2 = new Cliente(
    "José Mateus",
    "98765432198"
);

Cliente cliente3 = new Cliente(
    "Eluara",
    "85236958744"
); 

Veiculo veiculo1 = new Veiculo(
    "Civic",
    "123456"
);

Veiculo veiculo2 = new Veiculo(
    "Corolla",
    "654321"
);

Veiculo veiculo3 = new Veiculo(
    "HB20",
    "987654"
);

Locacao locacao1 = new Locacao(
    cliente1,
    veiculo2,
    new DateOnly(2026, 10, 10),
    6,
    150
);

Locacao locacao2 = new Locacao(
    cliente2,
    veiculo1,
    new DateOnly(2026, 10, 01),
    11,
    150
);

Locacao locacao3 = new Locacao(
    cliente3,
    veiculo3,
    new DateOnly(2026, 10, 01),
    18,
    150
);
locacao1.ExibirResumo();
locacao2.ExibirResumo();
locacao3.ExibirResumo();

