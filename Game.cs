using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Morgan_Daniel
{
    class Game
    {

        public string Title { get; } //properties with automatic getters, one called title, esrb, and genre, two strings and a char

        public char Esrb { get; }

        public string Genre { get; }

        public Game(string titleParam, char esrbParam, string genreParam) //assing each
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}
