
namespace GerenciaEstoque;

using System.Linq;
using System.Collections.Generic;

public class Estoque{
    private List<Produto> produtos;

    public Estoque(){
        produtos = new List<Produto>();
    }


    public List<Produto> getProdutos(){
        return produtos;
    }

    public void setProdutos(List<Produto> produtos){
        this.produtos = produtos;
    }
    public void AdicionarProduto(){
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Quantidade:");
        string quantidadeStr = Console.ReadLine()!;
        if (int.TryParse(quantidadeStr, out int quantidade)){}
        else{
            Console.WriteLine("Valor invalido!");
            Console.WriteLine("Nenhum produto adicionado!");
            return;
        }
        if (quantidade<0){
            Console.WriteLine("Não adimitimos quantidade negativa!");
            Console.WriteLine("Nenhum produto adicionado!");
            return;
        }
        Console.WriteLine("Preco:");
        string precoStr = Console.ReadLine()!;
        if (float.TryParse(precoStr, out float preco)){
        }
        else{
            Console.WriteLine("Valor invalido!");
            Console.WriteLine("Nenhum produto adicionado!");
            return;
        }
        if (preco<=0.0){
            Console.WriteLine("Não adimitimos preço não positivo!");
            Console.WriteLine("Nenhum produto adicionado!");
            return;
        }
        int codigo = produtos.Count;
        Produto item = new Produto(nome,codigo,quantidade,preco);
        produtos.Add(item);
        Console.WriteLine("Produto adicionado ao estoque!");
    }

    public void imprimeEstoque(){
        Console.WriteLine();
        foreach (Produto item in produtos){
            Console.Write($"Codigo: {item.getCodigo()}, ");
            Console.Write($"Nome: {item.getNome()}, ");
            Console.Write($"Quantidade: {item.getQuantidade()}, ");
            Console.WriteLine($"Preco/Und: {item.getPreco()} R$");
        }
    }

    public int localizaProduto(){
        Console.WriteLine("Digite o codigo do produto: ");
        var codigoStr = Console.ReadLine()!;
        if (int.TryParse(codigoStr, out int codigo)){}
        else{
            Console.WriteLine("Valor invalido!");
            return -1;
        }
        int index  = produtos.FindIndex(x => x.getCodigo() == codigo);
        if (index>=0){
            Console.WriteLine("Produto Encontrado!");
            Console.Write($"Codigo: {produtos[index].getCodigo()}, ");
            Console.Write($"Nome: {produtos[index].getNome()}, ");
            Console.Write($"Quantidade: {produtos[index].getQuantidade()}, ");
            Console.WriteLine($"Preco/Und: {produtos[index].getPreco()} R$");
        }
        else{
            Console.WriteLine("Produto não encontrado!");
        }
        return index;
    }

    public void alteraQuantidade(){
        int index = localizaProduto();
        if(index<0){
            return;
        }
        Console.WriteLine("Digite o delta de produtos (Positivo para adicionar e Negativo para remover)");
        var deltaStr = Console.ReadLine()!;
        if (int.TryParse(deltaStr, out int delta)){}
        else{
            Console.WriteLine("Valor invalido!");
            return;
        }
        produtos[index].editaQuantidade(delta);
        Console.WriteLine("Estoque alterado com sucesso!");
    }

}
