namespace Namespace;
public class App
{
public static List<Pessoa> AddPessoa(){
    List<Pessoa> pessoas = new List<Pessoa>();
    string sn = "s";
    do{
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a altura");
        int alturaCm = int.Parse(Console.ReadLine()!);
        
        Pessoa pessoa = new Pessoa(nome,alturaCm);
        pessoas.Add(pessoa);

    }while(sn.ToLower()=="s");
    return pessoas;
}

public static double calculaMedia(){
    
}


}
