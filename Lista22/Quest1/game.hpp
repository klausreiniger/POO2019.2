#ifndef GAME_H
#define GAME_H
#include <iostream>
#include <string>
#include <ctime>
#include <list>
#include <algorithm>

using namespace std;

class Game{
public:
    int Id, Estrelas;
    string Nome, Fabricante;
    time_t dtm;
}

#endif