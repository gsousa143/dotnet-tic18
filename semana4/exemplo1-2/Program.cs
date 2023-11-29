Veiculo passeio = new Veiculo();
passeio.Ano = 2020;
passeio.Cor = "verde";
passeio.Modelo = "golf";

passeio.imprimeVeiculo();

Console.WriteLine($"A idade do veiculo é: {passeio.IdadeVeiculo} anos");


class Veiculo{
    public string Modelo{get; set;}
    public string Cor{get; set;}
    public int Ano{get; set;}

    public void imprimeVeiculo(){
        Console.WriteLine($"Carro: Modelo - {Modelo}, Ano - {Ano}, Cor - {Cor}");
    }
    public int IdadeVeiculo => DateTime.Now.Year-Ano;
    public int AnoAtual => DateTime.Now.Year;
    public int IdadeDoCarro => AnoAtual-Ano;    
    
 
}

