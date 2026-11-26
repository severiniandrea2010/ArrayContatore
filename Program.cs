int[] v = new int[10];
bool ris = false;
int x;
int conta = 0;
for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Inserisci un valore nell'array");
    v[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Inserisci il numero che vuoi cercare");
x = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < v.Length;i++)
{
    if(x == v[i])
    {
        conta++;
    }
}
Console.WriteLine("Il numero e' presente "+ conta +" volte");