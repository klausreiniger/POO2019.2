#include "livro_auth.hpp"
#include "PLib.cpp"

class NLivro{
private:
    list<Livro> v;
    PLivro p;
public:
    list<Livro> Select(){
        string aux;
        for(int it = 0; it < v.size(); ++it){
            for(int ch = it + 1; ch < v.size(); ++ch){
                if(this->v[it]->Titulo > this->v[ch]->Titulo){
                    aux = this->v[it]->Titulo;
                    this->v[it]->Titulo = this->v[ch]->Titulo;
                    this->v[ch]->Titulo = aux;
                }
            }
        }
        return this->v;
    } 
    void Update(Livro l){
        for(int i = 0; i < this->v.size(); ++i){
            if(this->v[i]->Titulo == l.Titulo) this->v[i] = l&;
        }
    }
    void Insert(Livro l){
        this->v.Add(l);
    }
    void Delete(Livro l){
        this->v.Remove(l);
    }
}

class NAutor{
private:
    list<Autor> v;
    PAutor p;
public:
    list<Autor> Select(){
        string aux;
        for(int it = 0; it < v.size(); ++it){
            for(int ch = it + 1; ch < v.size(); ++ch){
                if(this->v[it]->Nome > this->v[ch]->Nome){
                    aux = this->v[it]->Nome;
                    this->v[it]->Nome = this->v[ch]->Nome;
                    this->v[ch]->Nome = aux;
                }
            }
        }
        return this->v;
    } 
    void Update(Autor a){
        for(int i = 0; i < this->v.size(); ++i){
            if(this->v[i]->Nome == l.Nome) this->v[i] = l&;
        }
    }
    void Insert(Autor a){
        this->v.Add(a);
    }
    void Delete(Autor a){
        this->v.Remove(a);
    }
}