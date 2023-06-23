StreamReader fin = new StreamReader("date.in");
StreamWriter fout = new StreamWriter("date.out");
List<int> sirNumere = new List<int>();

Citeste();

void Citeste()
{
    using (fin)
    {
        int n = int.Parse(fin.ReadLine());
        string[] sirLinie = fin.ReadToEnd().Split(" ");
        for (int i = 0; i < n; i++)
        {
            sirNumere.Add(int.Parse(sirLinie[i]));
        }
    }
}
Determina();

void Determina()
{
    using (fout)
    {
        fout.Write(SumElemente(sirNumere, 0, sirNumere.Count - 1));
        Console.WriteLine("Rezultatul a fost inscris cu succes in fisierul 'date.out' !");
    }
}

int SumElemente(List<int> sirNumere, int st, int dr)
{
    int mijloc, els, eld;
    if (st == dr)
    {
        return sirNumere[st];
    }
    else
    {
        mijloc = (st + dr) / 2;
        els = SumElemente(sirNumere, st, mijloc);
        eld = SumElemente(sirNumere, mijloc + 1, dr);
        return els + eld;
    }
}
