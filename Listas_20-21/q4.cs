using System;
using System.Collections.Generic;

class Funcionario{
  private string nome, email, fone;
  public void SetNome(string n){
    nome = n;
  }
  public void SetEmail(string e){
    email = e;
  }
  public void SetFone(string f){
    fone = f;
  }
  public string GetNome(){
    return this.nome;
  }
  public string GetEmail(){
    return email;
  }
  public string GetFone(){
    return fone;
  }
  public override string ToString(){
    return $"{nome} - {email} - {fone}";
  }
}

class Engenheiro : Funcionario{
  private string crea;
  public void SetCrea(string c){
    crea = c;
  }
  public string GetCrea(){
    return crea;
  }
  public override string ToString(){
    return $"Engenheiro {GetNome()} - {GetEmail()} - {GetFone()} - {GetCrea()}";
  }
}

class Motorista : Funcionario{
  private string cnh;
  public void SetCnh(string c){
    cnh = c;
  }
  public string GetCnh(){
    return cnh;
  }
  public override string ToString(){
    return$"Motorista -{GetNome()} - {GetEmail()} - {GetFone()} - {GetCnh()}";
  }
}

class Construtora{
  private List<Funcionario> funcs;
  public void Inserir(Funcionario f){
    funcs.Add(f);
  }
  public List<Funcionario> Funcionarios(){
    return funcs;
  }
  public List<Engenheiro> Engenheiros(){
    List<Engenheiro> aux = new List<Engenheiro>();
    foreach(Funcionario f in funcs) if(f is Engenheiro) aux.Add(f as Engenheiro);
    return aux;
  }
  public List<Motorista> Motoristas(){
    List<Motorista> aux = new List<Motorista>();
    foreach(Funcionario f in funcs) if(f is Motorista) aux.Add(f as Motorista);
    return aux;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
