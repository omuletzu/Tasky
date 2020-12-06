#include <iostream>
#include <graphics.h>
#include <ctime>
#include <cstdlib>
#include <fstream>

using namespace std;
pair<int,int>task;
string s[5][101];
int mod;

void configurare();   // partea de configurare a aplicatiei
void prima_oara();

string SeFaceData();

void init();

int main()
{
    prima_oara();
    init();
    //cout<<SeFaceData();
    if (task.first!=0)
    {
        if (task.second!=0) cout<<"You can not start another task. Finish at least 1 task to start another task.";
    }
}

string SeFaceData()
{
    time_t ttime=time(0);
    char* dt=ctime(&ttime);
    string s=dt;
    return s;
}

void prima_oara()
{
    ifstream fin("prima_oara.in");
    bool x;
    fin>>x;
    fin.close();
    if (x==false)
    {
        configurare();
        ofstream fout("prima_oara.in");
        fout<<1;
        fout.close();
    }
}

void configurare()
{
    ofstream fout("preferences.in");
    char c;
    s[0][0]="sport";
    s[1][0]="cooking";
    s[2][0]="read";
    s[3][0]="art";
    s[4][0]="play an instrument";
    cout<<"What would you like to do ?\n";
    cout<<"type y for yes, n for no and press ENTER\n";
    for (int i=0;i<=4;i++)
    {
        cout<<s[i][0]<<"\n";
        cin>>c;
        if (c=='y')
        {
            fout<<1<<" ";
            mod+=stoi(s[i][100]);
            //for (i=1;i<)
        }
        else if (c=='n') fout<<0<<" ";
        else
        {
            cout<<"type again\n";
            cin>>c;
            if (c=='y')
            {
                fout<<1<<" ";
                mod+=stoi(s[i][100]);
            }
            else if (c=='n') fout<<0<<" ";
        }
    }
}

void init()
{
    s[0][0]="sport";
    s[1][0]="cooking";
    s[2][0]="read";
    s[3][0]="art";
    s[4][0]="play an instrument";

    s[0][1]="do pushups";
    s[0][2]="squats";
    s[0][100]=2;

    s[1][1]="cookies";
    s[1][100]=1;

    s[2][1]="caragiale";
    s[2][2]="creanga";
    s[2][3]="arghezi";
    s[2][100]=3;

    s[3][1]="sketch";
    s[3][100]=1;

    s[4][1]="guitar";
    s[4][100]=1;
}
