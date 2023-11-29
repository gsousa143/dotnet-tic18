namespace GerenciaEstoque;

using System.Linq;
using System.Collections.Generic;



public class Relatorios{
    public static void abaixoDoMinimo(Estoque produtos){
        Console.WriteLine("Digite o valor de Estoque minimo");
        string quantidadeStr = Console.ReadLine()!;
        if (int.TryParse(quantidadeStr, out int quantidade)){
        }
        else{
            Console.WriteLine("Valor invalido!");
            return;
        }
        if (quantidade<0){
            Console.WriteLine("Não admitimos quantidade negativa!");
            return;
        }
        
        Estoque produtosAbaixo = new Estoque();
        produtosAbaixo.setProdutos(produtos.getProdutos().Where(x => x.getQuantidade() < quantidade).ToList());
        if (produtosAbaixo.getProdutos().Any()){
            produtosAbaixo.imprimeEstoque();
        }
        else{
            Console.WriteLine($"Não há produtos com estoque abaixo de {quantidade}");
        }
        
                

    }
    public static void intervaloPrecos(Estoque produtos){
        Console.WriteLine("Digite o preco minimo!");
        string precoStr = Console.ReadLine()!;
        if (float.TryParse(precoStr, out float precoinf)){
        }
        else{
            Console.WriteLine("Valor invalido!");
            return;
        }
        if (precoinf<0){
            Console.WriteLine("Não admitimos quantidade negativa!");
            return;
        }
        Console.WriteLine("Digite o preco maximo!");
        precoStr = Console.ReadLine()!;
        if (float.TryParse(precoStr, out float precosup)){
        }
        else{
            Console.WriteLine("Valor invalido!");
            return;
        }
        if (precosup<0){
            Console.WriteLine("Não admitimos quantidade negativa!");
            return;
        }
        if(precosup<precoinf){
            Console.WriteLine("Preço minimo maior que o preço maximo!");
            return;
        }
        Estoque produtosIntervalo = new Estoque();
        produtosIntervalo.setProdutos(produtos.getProdutos().Where(x => (x.getPreco() > precoinf)&&(x.getPreco() < precosup)).ToList());
        if (produtosIntervalo.getProdutos().Any()){
            produtosIntervalo.imprimeEstoque();
        }
        else{
            Console.WriteLine($"Não há produtos com preco entre {precoinf} R$ e {precosup} R$!");
        }

    }

    public static void valorDoEstoque(Estoque produtos){
        float valorTotal=0, valorProduto;
        if(produtos.getProdutos().Any()){
            foreach( Produto produto in produtos.getProdutos()){
                valorProduto = produto.getQuantidade()*produto.getPreco();
                valorTotal += valorProduto;
                Console.Write($"Codigo: {produto.getCodigo()}, ");
                Console.Write($"Nome: {produto.getNome()}, ");
                Console.Write($"Quantidade: {produto.getQuantidade()}, ");
                Console.Write($"Preco/Und: {produto.getPreco()} R$, ");
                Console.WriteLine($"Valor: {valorProduto} R$");
            }
            Console.WriteLine($"Valor do Estoque= {valorTotal} R$");
        }
        Console.WriteLine($"Estoque vazio. Valor = {valorTotal} R$");
    }

}
