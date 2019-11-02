using System;

interface ITeste{
  int Metodo1(int valor); 
}

class Teste : ITeste{
  public int Metodo1(int valor){
    if(valor < 0) throw new ArgumentOutOfRangeException("Número negativo");
    return valor;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Teste teste = new Teste();
    int a;
    a = teste.Metodo1(-1);
  }
}
