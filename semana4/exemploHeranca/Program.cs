
Conta contaGabriel = new Conta();
try{
    contaGabriel.setnumero(-100);
}
catch(Exception e){
Console.WriteLine(e);
}
class Conta{
    int numero;
    double saldo;

    public void setnumero(int numero){
        if (numero>0){
            this.numero = numero;
        }
        else{
            throw new Exception("Numero invalido");
        }
    }

}

class ContaCorrente : Conta{
    double limite;
}
