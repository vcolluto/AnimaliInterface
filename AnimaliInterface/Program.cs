using AnimaliInterface;

Mucca m=new Mucca();
m.FaiVerso();
m.Dormi();
m.Respira();

Gatto g=new Gatto();
g.FaiVerso();
g.Dormi();

IAnimale a;

Console.Write("Vuoi creare una mucca (m) o un gatto (g)? ");
string? scelta=Console.ReadLine();

if (scelta=="m") 
    a=new Mucca();
else if (scelta=="g")
    a=new Gatto();
else
{
    Console.WriteLine("Animale non valido!");
    return;
}

a.FaiVerso();
a.Dormi();
a.Corri();