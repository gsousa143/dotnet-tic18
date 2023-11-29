namespace GerenciaEstoque;

public class App{
    public static void menuPrincipal(Estoque produtos){
        string op;

        do{
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Imprime Estoque");
            Console.WriteLine("3 - Altera Quantidade");
            Console.WriteLine("4 - Localiza Produto");
            Console.WriteLine("5 - Menu de Relatorios");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite uma das opções do menu:");
            op = Console.ReadLine()!;
            switch(op){
                case "1":
                    Console.WriteLine("ADICIONAR PRODUTO");
                    produtos.AdicionarProduto();
                    break;
                case "2":
                    Console.WriteLine("IMPRIMIR ESTOQUE");
                    produtos.imprimeEstoque();
                    break;
                case "3":
                    Console.WriteLine("ALTERA QUANTIDADE");
                    produtos.alteraQuantidade();
                    break;
                case "4":
                    Console.WriteLine("LOCALIZA PRODUTO");
                    produtos.localizaProduto();
                    break;
                case "5":
                    Console.WriteLine("MENU DE RELATORIOS");
                    App.menuRelatorios(produtos);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Valor invalido!");
                    break;
            }
        }while(op != "0");
    }

    public static void menuRelatorios(Estoque produtos){
        string op;
        do{
            Console.WriteLine("1 - Produtos Abaixo do Estoque Minimo");
            Console.WriteLine("2 - Produtos Dentro de um Limite de Preço");
            Console.WriteLine("3 - Valor do Estoque");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite uma das opções do menu:");
            op = Console.ReadLine()!;
            switch(op){
                case "1":
                    Console.WriteLine("PRODUTOS ABAIXO DO MINIMO");
                    Relatorios.abaixoDoMinimo(produtos);
                    break;
                case "2":
                    Console.WriteLine("PRODUTOS DENTRO DE UM LIMITE DE PRECO");
                    Relatorios.intervaloPrecos(produtos);
                    break;
                case "3":
                    Console.WriteLine("VALOR DO ESTOQUE");
                    Relatorios.valorDoEstoque(produtos);
                    break;
                case "0":
                    App.menuPrincipal(produtos);
                    break;
                default:
                    Console.WriteLine("Valor invalido!");
                    break;
            }
        }while(op != "0");
    }
}
