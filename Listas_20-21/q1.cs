using System;

class Retangulo{
  private double b,h;
  public Retangulo(double b, double h){
    if(b > 0 && h > 0){
      this.b = b;
      this.h = h;
    }else{
      throw new ArithmeticException("Medida escalar negativa");
    }
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    return b*h;
  }
  public double CalcDiagonal(){
    return Math.Sqrt(b*b + h*h);
  }
  public override string ToString(){
    return $"Base: {b} - Altura: {h} - Area: {CalcArea()}";
  }
}

class Quadrado : Retangulo{
  public Quadrado(double l) : base(l,l){}
  public override string ToString(){
    return $"Lado: {GetBase()} - Area: {CalcArea()}";
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Quadrado square = new Quadrado(5);
    Console.WriteLine(square.ToString());
    Retangulo ret = new Retangulo(2,3);
    Console.WriteLine(ret.ToString());
  }
}
