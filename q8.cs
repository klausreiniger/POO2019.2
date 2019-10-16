using System;
using System.Collections;
using System.Collections.Generic;

class Pilha2<T>{
  private Queue<T> q1, q2;
  public int Count(){
    if(q1.Count != 0) return q1.Count;
    return q2.Count;
  }
  public T Top(){
    T qq;
    if(q1.Count != 0){
      for(int i = 0; i < Count() - 1; i++){
        q2.Enqueue(q1.Peek);
        q1.Dequeue();
      }
      qq = q1.Peek;
      q2.Enqueue(q1.Peek);
      q1.Dequeue();
      return qq;
    }else{
      for(int i = 0; i < Count() - 1; i++){
        q1.Enqueue(q2.Peek);
        q2.Dequeue();
      }
      qq = q2.Peek;
      q1.Enqueue(q2.Peek);
      q2.Dequeue();
      return qq;
    }
  }
  public T Pop(){
    T qq;
    if(q1.Count != 0){
      for(int i = 0; i < Count() - 1; i++){
        q2.Enqueue(q1.Peek);
        q1.Dequeue();
      }
      qq = q1.Peek;
      q1.Dequeue();
      return qq;
    }else{
      for(int i = 0; i < Count() - 1; i++){
        q1.Enqueue(q2.Peek);
        q2.Dequeue();
      }
      qq = q2.Peek;
      q2.Dequeue();
      return qq;
    }
  }
  public void Push(T obj){
    if(q1.Count != 0) q1.Enqueue(T);
    else q2.Enqueue(T);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
