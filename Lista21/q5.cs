using System;
using System.Collections.Generic;

class Dicionario<K,V> {
  private List<K> keys;
  private List<V> values;
  public List<K> Chaves{
    get {
      return keys;
    }
  }
  public int Count{
    get{
      return keys.Count;
    }
  }
  public void Clear(){
    keys.Clear();
    values.Clear();
  }
  public bool Contains(K chave){
    foreach(K pass in keys) if (pass.Equals(chave)) return true;
    return false;
  }
  public bool Remove(K chave){
    if (!Contains(chave)) return false;
    values.Remove(values[keys.IndexOf(chave)]);
    keys.Remove(chave);
    return true;
  }
  public void Add(K chave, V valor){
    if(valor == null) throw new ArgumentNullException("Expected not null value");
    if (Contains(chave)) throw new InvalidOperationException("Already existing key");
    keys.Add(chave);
    values.Add(valor);
  }
  public V this[K index]{
    get{ 
      if(!Contains(index)) throw new InvalidOperationException("Not existing index");
      return values[keys.IndexOf(index)];
    }
    set {
      if(!Contains(index)){
        Add(index, value);
      }else{
        values[keys.IndexOf(index)] = value;
      }
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
