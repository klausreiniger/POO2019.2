using System;

class ContaCorrente{
  private string titular, numeroConta;
  protected double saldo;
  public ContaCorrente(string t, string n){
    titular = t;
    numeroConta = n;
  }
  public void Depositar(double valor){
    saldo += valor;
  }
  public virtual bool Sacar(double valor){
    if(saldo >= valor){
      saldo -= valor;
      return true;
    }
    else return false;
  }
  public double RetornarSaldo(){
    return saldo;
  }
  public override string ToString(){
    return $"Titular:{titular} - Conta:{numeroConta} - Saldo: {saldo}";
  }
}

class ContaEspecial : ContaCorrente{
  private double limite;
  public ContaEspecial(string t, string n, double l) : base(t,n){
    limite = l;
  }
  public override bool Sacar(double valor){
    if(limite >= valor - saldo){
      saldo -= valor;
      return true;
    }
    return false;
  }
}

class Poupança : ContaCorrente{
  public Poupança(string t, string n) : base(t,n){}
  public void Render(double juros){
    saldo += saldo * juros;
  }
}

class MainClass {
  public static void Main (string[] args) {
    ContaCorrente ex = new ContaCorrente("klaus","004");
    Console.WriteLine(ex.ToString());
    ContaEspecial ex1 = new ContaEspecial("klaus","004", 455);
    Console.WriteLine(ex1.ToString());
    Poupança pop = new Poupança("n", "ew");
    Console.WriteLine(pop.ToString());
  }
}
