using System;
using System.Collections;
using System.Collections.Generic;

class Pilha1<T>{
  private List<T> lista;
  public int Count(){
    return lista.Count;
  }
  public T Top(){
    return lista[lista.Count - 1];
  }
  public T Pop(){
    T value = this.Top();
    lista.RemoveAt(lista.Count - 1);
    return value;
  }
  public void Push(T obj){
    lista.Add(obj);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
