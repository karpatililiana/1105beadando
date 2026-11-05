// 6. Jelszó erősség számoló
int jelszo_erosseg(string jelszo)
{
    if (jelszo.Length == 0)
    {
        return 0;
    }
    if (jelszo.Contains("jelszo"))
    {
        return 0;
    }
    if (jelszo.Contains("123"))
    {
        return 0;
    }
    int pont = 1;
    if (jelszo.Length >= 5)
    {
        pont += 1;
    }
    if (jelszo.Length >= 8)
    {
        pont += 2;
    }

    foreach (char o in jelszo)
    {
        if (o == '-')
        {
            pont += 2;
        }
        if (o == '_')
        {
            pont += 2;
        }
        if (o == '.')
        {
            pont += 2;
        }
    }
    return pont;

}
Console.WriteLine(jelszo_erosseg("Skibiditoiletsigma-453"));
Console.WriteLine(jelszo_erosseg("jelszomittudomen"));


// 7. Magánhangzó eltávolítás
string maganhangzo_torol(string szoveg)
{
    string maganhangzok = "aeiuoAEIUO";
    string ujszoveg = " ";
    foreach (char i in szoveg)
    {
        if (maganhangzok.Contains(i) == false)
        {
            ujszoveg += i;
        }
    }
    return ujszoveg;
}
Console.WriteLine(maganhangzo_torol("Anyadretkespicsajat"));

// 8. Szöveg titkosítása
string kodol(string uzi, int n, char c)
{
    string output = " ";
    foreach (char j in uzi)
    {
        output += j;
        for (int k = 0; k < n; k += 1)
        {
            output += c;
        }
    }
    return output;
}
Console.WriteLine(kodol("Sziacicavangazdad", 3, 'e'));