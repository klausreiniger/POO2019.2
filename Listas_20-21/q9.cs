using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

class Contato{
  public string Nome, Email, Fone;
}

class Agenda{
  private List<Contato> cs;
  public void Inserir(Contato c){
    cs.Add(c);
  }
  public List<Contato> Listar(){
    return cs;
  }
  public List<Contato> Pesquisar(string inicio){
    List<Contato> keys;
    foreach(Contato c in cs) if(c.Nome.Contains(inicio)) keys.Add(c);
    return keys;
  }
  public void Abrir(){
    XmlWriter xmlWriter = XmlWriter.Create("contatos.xml");
    xmlWriter.WriteStartDocument();
    xmlWriter.WriteStartElement("contatos");
    for(i = 0; i < cs.Count; i++){
      xmlWriter.WriteStartElement("Nome");
      xmlWriter.WriteAttributeString("Email", cs[i].Email);
      xmlWriter.WriteAttributeString("Fone", cs[i].Fone);
      xmlWriter.WriteString(cs[i].Nome);
      xmlWriter.WriteEndElement();
    }
    xmlWriter.WriteEndElement();
    xmlWriter.WriteEndDocument();
    xmlWriter.Close();
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
