using System;
using System.Collections.Generic;

class InversaoSaldoException(){
  private double dif;
  protected InversaoSaldoException() : base(){
  }
  protected InversaoSaldoException(double dif) : base($"R${0} is negative, excepted positive value", dif){
    this.dif = dif;
  }
}

class ContaBancaria{
  protected double saldo = 0;
  protected string numero;
  public string getN(){
    return numero;
  }
  public ContaBancaria(string n){
    numero = n;
  }
  public deposito(int value){
    if(value < 0) throw new ArgumentOutOfRangeException($"{value} is negative, expected positive value");
    else saldo += value;
  }
  public double GetSaldo(){
    return saldo;
  }
  public sacar(int value){
    if (value < 0) throw new ArgumentOutOfRangeException($"{value} is negative, expected positive value");
    else if (value > saldo) throw new InversaoSaldoException(value - saldo);
    else saldo -= value;
  }
}

class Cliente{
  private string nome, email, fone;
  public List<ContaBancaria> contas = new List<ContaBancaria>();
  public Cliente(string nome, string email, string fone){
    this.nome = nome;
    this.email = email;
    this.fone = fone;
  }
  public addAccount(ContaBancaria conta){
    contas.Add(conta);
  }
}

class MainClass {
  public static void Main (string[] args) {
    string nome, email, fone;
    Console.WriteLine("Digite o nome, email e fone do cliente");
    Console.ReadLine(nome);
    Console.ReadLine(email);
    Console.ReadLine(fone);
    Cliente cliente = new Cliente(nome,email,fone);
    while(true){
      Console.WriteLine("Adicionar Conta (S / N)");
      Console.ReadLine(nome);
      if(nome == "S"){
        Console.WriteLine("Digite o numero da conta");
        Console.ReadLine(nome);
        ContaBancaria cc = new ContaBancaria(nome);
        cliente.addAccount(cc);
      }
      else{
        Console.WriteLine("Digite o numero da conta");
        Console.ReadLine(nome);
        Console.WriteLine("Digite a operação (S / D / GS)");
        Console.ReadLine(email);
        foreach(ContaBancaria c in cliente.contas){
          if(c.getN() == nome){
            if(email == "S"){
              Console.WriteLine("Digite o valor");
              Console.ReadLine(fone);
              c.sacar(fone);
            }
            if(email == "D"){
              Console.WriteLine("Digite o valor");
              Console.ReadLine(fone);
              c.deposito(fone);
            }
            if(email == "GS"){
              Console.WriteLine(c.GetSaldo());
            }
          }
        }
      }
      Console.WriteLine("Deseja realizar outra operação (S /N )");
      Console.ReadLine(nome);
      if(nome == "N") break;
    }
  }
}
