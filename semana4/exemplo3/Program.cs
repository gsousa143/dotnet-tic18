

ContaBancaria c1 = new ContaBancaria();
c1.Saldo = -2;

class ContaBancaria{
    private double saldo;
    public double Saldo{
        get{
            return this.saldo;
        }
        set{
            if(value>0){
                this.saldo = value;
            }
            else{
                throw new ArgumentException("Saldo não pode ser negativo");
            }
        }
    }


}