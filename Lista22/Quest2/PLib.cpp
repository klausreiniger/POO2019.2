#include "livro_auth.hpp"

class PLivro{
private:
    string file_path;
public:
    list<Livro> Open(){
        ifstream leitura(file_path);
        list<Livro> livrospath;
        while(!leitura.eof()){
            Livro* newl = new Livro();
            livrospath.push_back(*newl);
            getline(livrospath.back()->Id, leitura);
            getline(livrospath.back()->Titulo, leitura);
            getline(livrospath.back()->Sinopse, leitura);
            getline(livrospath.back()->Genero, leitura);
            getline(livrospath.back()->IdAutor, leitura);
        }
        return livrospath;
    }
    void Save(list<Livro> output){
        ofstream leitura(file_path);
        while(!output.empty()){
            leitura << livrospath.begin()->Id;
            leitura << livrospath.begin()->Titulo;
            leitura << livrospath.begin()->Sinopse;
            leitura << livrospath.begin()->Genero;
            leitura << livrospath.begin()->IdAutor;
            output.pop_front();
        } 
    }
}

class PAutor{
private:
    string file_path;
public:
    list<Autor> Open(){
        ifstream leitura(file_path);
        list<Autor> livrospath;
        while(!leitura.eof()){
            Autor* newl = new Autor();
            livrospath.push_back(*newl);
            getline(livrospath.back()->Id, leitura);
            getline(livrospath.back()->Nome, leitura);
            getline(livrospath.back()->Biografia, leitura);
        }
        return livrospath;
    }
    void Save(list<Autor> output){
        ofstream leitura(file_path);
        while(!output.empty()){
            leitura << livrospath.begin()->Id;
            leitura << livrospath.begin()->Nome;
            leitura << livrospath.begin()->Biografia;
            output.pop_front();
        } 
    }
}