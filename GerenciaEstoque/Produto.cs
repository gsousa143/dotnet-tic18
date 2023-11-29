namespace GerenciaEstoque;


 public class Produto{
    private (string nome, int codigo, int quantidade, float preco) item;


    public string getNome(){
        return item.nome;
    }

    public int getCodigo(){
        return item.codigo;
    }

    public int getQuantidade(){
        return item.quantidade;
    }
    public void setQuantidade(int quantidade){
        item.quantidade = quantidade;
    }

    public float getPreco(){
        return item.preco;
    }

    public Produto(string nome, int codigo, int quantidade, float preco){
       item = (nome, codigo, quantidade, preco);
    }
    public void editaQuantidade(int delta){
        if(item.quantidade+delta<0){
            Console.WriteLine("Quantidade solicitada maior que o disponivel!");
            Console.WriteLine("Nenhuma alteração foi realizada!");
            return;
        }
        setQuantidade(getQuantidade()+delta); 
    }
}
