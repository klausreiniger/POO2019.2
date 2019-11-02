#include "game.hpp"
#include <fstream>

class PGame{
private:
    string file_path;
public:
    list<Game> Open(){
        ifstream leitura(file_path);
        list<Game> gamespath;
        while(!leitura.eof()){
            Game* newg = new Game();
            gamespath.push_back(*newg);
            getline(gamespath.back()->Id, leitura);
            getline(gamespath.back()->Nome, leitura);
            getline(gamespath.back()->Fabricante, leitura);
            getline(gamespath.back()->DataCompra, leitura);
            getline(gamespath.back()->Estrelas, leitura);
        }
        return gamespath;
    }
    void Save(list<Game> output){
        ofstream leitura(file_path);
        while(!output.empty()){
            leitura << gamespath.begin()->Id;
            leitura << gamespath.begin()->Nome;
            leitura << gamespath.begin()->Fabricante;
            leitura << gamespath.begin()->DataCompra;
            leitura << gamespath.begin()->Estrelas;
            output.pop_front();
        } 
    }
}