#include <iostream>
#include <cstdio>
#include <sstream>
#include <string>
using namespace std;

int main()
{
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j <= 9; j++)
        {
            stringstream input;
            input << "Bear__0" << i << j << ".png";
            string from = input.str();
            stringstream res;
            res << "Bear_" << i*10 + j << ".png";
            string to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            /*
            input << "Cat__0" << i << j << ".png";
            from = input.str();
            res << "Cat_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Cow__0" << i << j << ".png";
            from = input.str();
            res << "Cow_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Dog__0" << i << j << ".png";
            from = input.str();
            res << "Dog_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Elephant__0" << i << j << ".png";
            from = input.str();
            res << "Elephant_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");
            */
            input << "Giraffe__0" << i << j << ".png";
            from = input.str();
            res << "Giraffe_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");
            /*
            input << "Goat__0" << i << j << ".png";
            from = input.str();
            res << "Goat_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Horse__0" << i << j << ".png";
            from = input.str();
            res << "Horse_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Monkey__0" << i << j << ".png";
            from = input.str();
            res << "Monkey_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            input.str("");
            res.str("");

            input << "Wolf__0" << i << j << ".png";
            from = input.str();
            res << "Wolf_" << i*10 + j << ".png";
            to = res.str();
            cout << to << endl;
            rename(from.c_str(),to.c_str());
            */
        }
    }
    return 0;
}
