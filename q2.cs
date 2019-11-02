using System;

class Rectangle{
  private double height, width;
  public void SetBase(double b){
    if(b < 0) throw new ArgumentOutOfRangeException("Negative double as input, expected unsigned");
    else width = b;
  }
  public void SetAltura(double h){
    if(h < 0) throw new ArgumentOutOfRangeException("Negative double as input, expected unsigned");
    else height = h;
  }
  public double CalcArea(){
    return b*h;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}