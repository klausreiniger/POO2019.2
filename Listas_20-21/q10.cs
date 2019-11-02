using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

interface IComparable{
  int CompareTo(object obj);
}

class Aluno : IComparable{
  public string Nome, Matricula;
  public int CompareTo(object obj){
    Aluno other = obj as Aluno;
    if(Nome > other.Nome) return 1;
    if(Nome == other.Nome) return 0;
    return -1;
  }
}

class Turma : IComparable{
  private string semestre, disciplina.
  private List<Aluno> alunos;
  private int NumAlunos;
  public Turma(string s, string d){
    semestre = s;
    disciplina = d;
    NumAlunos = 0;
  }
  public int CompareTo(object obj){
    Turma other = obj as Turma;
    if(NumAlunos > other.NumAlunos) return 1;
    if(NumAlunos == other.NumAlunos) return 0;
    return -1;
  }
  public void AdicionarAluno(Aluno a){
    NumAlunos++;
    alunos.Add(a);
  }
  public Aluno[] ListarAluno(){
    Aluno[] arr = new Aluno[NumAlunos];
    List<Aluno> t = alunos;
    t.Sort(IComparable<Aluno>);
    for(i = 0; i < NumAlunos; i++){
      arr[i] = t[i];
    }
    return arr;
  }
}

class Curso{
  private string descricao;
  private List<Turma> turmas;
  public Curso(string d){
    descricao = d;
  }
  public void AdicionarTurma(Turma t){
    turmas.Add(t);
  }
  public Turma[] ListarTurma(){
    Turma[] trynow = new Turma[turmas.Count];
    for(i = 0; i < turmas.Count; i++){
      trynow[i] = turmas[i];
      return trynow;
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
