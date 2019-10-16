using System;

class Frete{
  protected double distancia, peso;
  public Frete(double d, double p){
    if(d > 0 && p > 0){
      distancia = d;
      peso = p;
    }else{
      throw new ArithmeticException("Valores escalares negativos");
    }
  } 
  public virtual decimal CalcFrete(){
    return Convert.ToDecimal(distancia * peso / 100);
  }
  public override string ToString(){
    return $"Distância: {distancia} - Peso: {peso} - Preço: {CalcFrete()}";
  }
}

class FreteExpresso : Frete{
  private decimal seguro;
  public FreteExpresso(double d, double p, decimal s) : base(d,p){
    seguro = s;
  }
  public override decimal CalcFrete(){
    return Convert.ToDecimal(distancia * peso / 100) + seguro / 100;
  }
  public override string ToString(){
    return $"Distância: {distancia} - Peso: {peso} -
    Seguro: {seguro} Preço: {CalcFrete()}";
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Frete normal = new Frete(1000,50);
    Console.WriteLine(normal.ToString());
    FreteExpresso diferenciado = new FreteExpresso(1000,50,1000000);
    Console.WriteLine(diferenciado.ToString());
  }
}
