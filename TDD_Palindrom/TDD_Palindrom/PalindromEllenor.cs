using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;



public class PalindromEllenor
{
    private HashSet<char> uresBetuk;
    private HashSet<char> irasJelek;
    private HashSet<string> duplaBetuk;

    public PalindromEllenor()
    {
        uresBetuk = new HashSet<char> { ' ' };
        irasJelek = new HashSet<char> { ',', '.', '!', '?' };
        duplaBetuk = new HashSet<string> { "dz", "cs", "gy", "sz", "zs" };
    }

    public PalindromEllenor(Dictionary<string, List<string>> elhagyandóKarakterek)
    {
        if (elhagyandóKarakterek.TryGetValue("uresBetuk", out List<string> uresBetukList))
        {
            uresBetuk = new HashSet<char>(uresBetukList[0].ToCharArray());
        }
        else
        {
            uresBetuk = new HashSet<char> { ' ' };
        }

        if (elhagyandóKarakterek.TryGetValue("irasJelek", out List<string> irasJelekList))
        {
            List<char> irasJelekChars = new List<char>();
            foreach (string irasJel in irasJelekList)
            {
                irasJelekChars.AddRange(irasJel.ToCharArray());
            }
            irasJelek = new HashSet<char>(irasJelekChars);
        }
        else
        {
            irasJelek = new HashSet<char> { ',', '.', '!', '?' };
        }

        if (elhagyandóKarakterek.TryGetValue("duplaBetűk", out List<string> duplaBetűkList))
        {
            duplaBetuk = new HashSet<string>(duplaBetűkList);
        }
        else
        {
            duplaBetuk = new HashSet<string> { "dz", "cs", "gy", "zs", "sz" };
        }
    }

    public bool EgyszeruPalindrom(string szo)
    {
        if (szo == null)
        {
            throw new NemMegfeleloParameterException();
        }

        if (szo == string.Empty)
        {
            return true;
        }

        string normalizedSzo = NormalizeSzo(szo);
        string reversedSzo = ReverseString(normalizedSzo);

        return normalizedSzo == reversedSzo;
    }

    public bool OsszetettPalindrom(string mondat)
    {
        if (mondat == null)
        {
            throw new NemMegfeleloParameterException();
        }

        if (mondat == string.Empty)
        {
            return true;
        }

        string normalizedMondat = NormalizeMondat(mondat);
        string reversedMondat = ReverseString(normalizedMondat);

        return normalizedMondat == reversedMondat;
    }

    public string NormalizeSzo(string szo)
    {
        string normalizedSzo = szo.ToLower();

        foreach (char karakter in uresBetuk)
        {
            normalizedSzo = normalizedSzo.Replace(karakter.ToString(), string.Empty);
        }

        return normalizedSzo;
    }

    public string NormalizeMondat(string mondat)
    {
        string normalizedMondat = mondat.ToLower();

        foreach (char karakter in uresBetuk)
        {
            normalizedMondat = normalizedMondat.Replace(karakter.ToString(), string.Empty);
        }

        foreach (char karakter in irasJelek)
        {
            normalizedMondat = normalizedMondat.Replace(karakter.ToString(), string.Empty);
        }

        return normalizedMondat;

    }

    public string ReverseString(string szo)
    {
        char[] charTomb = szo.ToCharArray();
        char temp;

        for (int i = 0; i < charTomb.Length - 1; i++)
        {
            string ellenorizendoBetuk = string.Concat(charTomb[i], charTomb[i + 1]);
            if (duplaBetuk.Contains(ellenorizendoBetuk))
            {
                temp = charTomb[i + 1];
                charTomb[i + 1] = charTomb[i];
                charTomb[i] = temp;
            }
        }
        Array.Reverse(charTomb);
        return new string(charTomb);
    }
}