using System;
using System.Collections.Generic;

interface IComparable{
  int CompareTo(object obj);
}

class Jogador : IComparable{
  private string nome, email;
  private DateTime data;
  private int pontuacaoMaxima;
  public Jogador(string nome, string email){
    this.nome = nome;
    this.email = email;
  }
  public string getEmail(){
    return email;
  }
  public int getMaxScore(){
    return this.pontuacaoMaxima;
  }
  public DateTime getData(){
    return this.data;
  }
  public int CompareTo(object obj){
    int current = pontuacaoMaxima.CompareTo((obj as Jogador).getMaxScore());
    if (current == 0) return data.CompareTo((obj as Jogador).getData());
    return current;
  }
  public void SetPontos(int p, DateTime d){
    if((d.CompareTo(DateTime.Now)) == 1) throw new ArgumentOutOfRangeException("Future DateTime given");
    else if(p < 0) throw new ArgumentOutOfRangeException("Negative score given");
    else{
      this.pontuacaoMaxima = p;
      this.data = d;
    }
  }
  public override string ToString(){
    return $"Nome {nome} - Email {email} - MaxScore {pontuacaoMaxima} - Data {data}";
  }
}

class EmailExistenteException : ArgumentOutOfRangeException{
  public EmailExistenteException(string msg) : base (msg) {} 
  }

class Jogo{
  private string nome;
  private List<Jogador> jogs = new List<Jogador>();
  public Jogo(string n){ nome = n;}
  public void Inserir(Jogador j){
    foreach(Jogador inst in jogs) if(inst.getEmail() == j.getEmail()) throw new EmailExistenteException($"Email existente {j.getEmail()}");
    jogs.Add(j);
  }
  public List<Jogador> Listar(){
    Jogador[] jogsp = new Jogador[jogs.Count];
    Array.Sort(jogsp);
    for(int i = 0; i < jogs.Count; i++){
      jogs[i] = jogsp[i];
    }
    return jogs;
  }
  public Jogador Top1(){
    return Listar()[0];
  }
  public List<Jogador> Top10(){
    List<Jogador> template = new List<Jogador>();
    List<Jogador> root = Listar();
    for(int i = 0; i < 10; i++){
      template.Add(root[i]);
    }
    return template;
  }
  public override string ToString(){
    return $"Nome {nome} - Best Performer {Top1().ToString()};";
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}