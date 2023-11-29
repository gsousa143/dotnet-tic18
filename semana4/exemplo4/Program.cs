Aluno a = new Aluno("gabriel",18);
Console.WriteLine($"{a.Nome}, {a.Idade}");


class Aluno{
    private string nome;
    private int idade;

    public string Nome{
        get{
            return nome;
        }
        set{
            nome = value;
        }
    }

    public int Idade{
        get{
            return idade;
        }
        set{
            idade = value;
        }
    }
    public Aluno(string nome,int idade){
        this.nome = nome;
        this.idade = idade;
    }
}