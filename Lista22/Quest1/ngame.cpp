#include "pgame.cpp"
#include "game.hpp"

class NGame{
private:
    list<Game> v;
    PGame p;
public:
    list<Game> Select(){
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
    void Update(Game g){
        for(int i = 0; i < this->v.size(); ++i){
            if(this->v[i]->Nome == g.Nome) this->v[i] = g&;
        }
    }
    list<Game> SelectData(){
        time_t aux;
        for(int it = 0; it < v.size(); ++it){
            for(int ch = it + 1; ch < v.size(); ++ch){
                time_t* itr = (this->v[it]->dtm)&;
                time_t* chr = (this->v[ch]->dtm)&;
                if(difftime(*chr, *itr) > 0){
                    aux = *itr;
                    *itr = *chr;
                    *chr = aux;
                }
            }
        }
        return this->v;
    }
    list<Game> Top10(){
        int aux;
        for(int it = 0; it < v.size(); ++it){
            for(int ch = it + 1; ch < v.size(); ++ch){
                if(this->v[ch]->Estrelas > this->v[ir]->Estrelas){
                    aux = this->v[it]->Estrelas;
                    this->v[it]->Estrelas = this->v[ch]->Estrelas;
                    this->v[ch]->Estrelas = aux;
                }
            }
        }
        list<Game> T10;
        std::copy(this->v.begin(), this->v.end(), T10.begin());
        T10.resize(10);
        return T10;
    }
    void Insert(Game g){
        this->v.Add(g);
    }
    void Delete(Game g){
        this->v.Remove(g);
    }
}