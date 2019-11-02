using System;
using System.Collections.Generic;

class Contato{
  private string nome, fone;
  public Contato(string n, string f){
    nome = n;
    fone = f;
  }
  public override string ToString(){
    return $"{nome} - {fone}";
  }
}

class Grupo{
  private string descricao;
  private int index;
  private Contato[] contatos;
  public Grupo(string d){
    descricao = d;
    index = 0;
  } 
  public void Adicionar(Contato c){
    contatos[index++] = c;
  }
  public void Excluir(Contato c){
    for(int i = 0; i < index; i++){
      if(contatos[i] == c) contatos[i] = null;
    }
  }
  public Contato[] ListarContatos(){
    int tent = 0;
    foreach(Contato c in contatos) if(c != null) tent++;
    Contato[] rt = new Contato[tent];
    tent = 0;
    foreach(Contato c in contatos) if(c != null) rt[tent++] = c;
    return rt;
  }
  public override string ToString(){
    return $"Grupo - {descricao}";
  }
}

class Usuario : Contato{
  private Contato[] contatos;
  private Grupo[] grupos;
  private int conts, grps;
  public Usuario(string n, string f) : base(n,f){
      conts = 0;
      grps = 0;
    }
  public void InserirContato(Contato c){
    contatos[conts++] = c;
  }
  public void InserirGrupo(Grupo g){
    grupos[grps++] = g;
  }
  public Contato[] ListarContatos(){
    return contatos;
  }
  public Grupo[] ListarGrupos(){
    return grupos;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
