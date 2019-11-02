using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

class Cliente{
  private string nome,cpf;
  private decimal limite;
  private List<Cliente> socio;
  public LimiteTotal{
    get {
      decimal k = limite;
      foreach(Cliente bg in socio) k += bg.limite;
      return bg;
    }
  }
  public Cliente(string n, string c, decimal l){
    nome = n;
    cpf = c;
    limite = l;
  }
  public void Inserir(Cliente c){
    socio.Add(c);
  }
  public void Remover(Cliente c){
    socio.Remove(c);
  }
}

class Empresa{
  private List<Cliente> clientes;
  public void Inserir(Cliente c){
    clientes.Add(c);
  }
  public void Remover(Cliente c){
    clientes.Remove(c);
  }
  public void Socios(Cliente x, Cliente y){
    
  } 
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
