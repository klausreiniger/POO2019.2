using System;
using System.Collections;
using System.Collections.Generic;

class Conversor{
  private int num;
  private Stack<int> pilha;
  public void SetNum(int num){
    if(num > 0){
      this.num = num;
    }
    else{
      throw new ArithmeticException("negative number, expected unsigned value");
    }
  }
  public string Binario(){
    while(num != 0){
      pilha.Push(num % 2);
      num /= 2;
    }
    int aux;
    string recieve = "";
    while(pilha.Count != 0){
      aux = pilha.Pop();
      num = num*2 + aux;
      recieve += Convert.ToString(aux); 
    }
    return recieve;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
