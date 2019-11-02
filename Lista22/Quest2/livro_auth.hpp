#ifndef STORE_H
#define STORE_H
#include <iostream>
#include <string>
#include <list>

using namespace std;

class Livro{
public:
    int Id, IdAutor;
    string Titulo, Sinopse, Genero;
}

class Autor{
public:
    int Id;
    string Nome, Biografia;
}

#endif