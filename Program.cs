using System;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> oyunlistem = new MyDictionary<string>();

            oyunlistem.Add("CS:GO");
            oyunlistem.Add("PUBG");
            oyunlistem.Add("LOL");
            oyunlistem.Add("DOTA");
            oyunlistem.Add("CoD");
            oyunlistem.Add("FOREST");


        }
    }
}
