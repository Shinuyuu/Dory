void Shin(string frase, int fun)
{
     if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(40);
}
}
Console.Clear();
Shin("Digite o que você quer que a Dory fale: ",02);
string frase = Console.ReadLine()!;
Console.Clear();
string baleia = frase.ToUpper().Replace("A","aaa").Replace("O","ooo").Replace("E","eee").Replace("I","iii").Replace("U","uuu").Replace("À","ààà")
.Replace("Á","ááá").Replace("Â","âââ").Replace("Ã","ããã").Replace("É","ééé").Replace("È","èèè").Replace("Ê","êêê").Replace("Ò","òòò").Replace("Ó","óóó");
string traducao =baleia.Substring(0,1).ToUpper()+baleia.Substring(1).ToLower();
Shin($"olá, eu sou a Dory... então você quer que eu fale: ",02);
Shin(traducao,01);
Console.ResetColor();