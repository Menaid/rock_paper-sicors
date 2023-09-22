string[] strategi = File.ReadAllLines("Menaid.txt");

var poäng = 0;

for (int i = 0; i < strategi.Length; i++)
{
    if (strategi[i].Contains("A X"))
    {
        poäng += 1;
    }

    if (strategi[i].Contains("A Y"))
    {
        poäng += 4;
    }

    if (strategi[i].Contains("A Z"))
    {
        poäng += 7;
    }

    if (strategi[i].Contains("B X"))
    {
        poäng += 3;
    }

    if (strategi[i].Contains("B Y"))
    {
        poäng += 5;
    }

    if (strategi[i].Contains("B Z"))
    {
        poäng += 9;
    }

    if (strategi[i].Contains("C X"))
    {
        poäng += 4;
    }

    if (strategi[i].Contains("C Y"))
    {
        poäng += 6;
    }

    if (strategi[i].Contains("C Z"))
    {
        poäng += 9;
    }

}
Console.WriteLine(poäng);

//13415

/*
int vinst = 6;
int oavgjort = 3;
int förlust = 0;

int sten = 1;
int påse = 2;
int sax = 3;
*/