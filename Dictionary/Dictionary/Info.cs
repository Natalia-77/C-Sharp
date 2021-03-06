﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Info
    {
        public Dictionary<string, string> dict;

        public Info()
        {
            dict = new Dictionary<string, string>();
        }

        public void Add(string key,string value)
        {
            dict.Add(key,value);
        }

        public bool TranslateWord(string item,bool status)
        {
            // Потім в мейні буде задано,що при статусі фолс перекладати буде з англ. на укр.мову.
            if(status==false)
            {
                // Якщо в словнику немає такого ключа(країни).
                if (dict.ContainsKey(item) == false)
                {
                    Console.WriteLine("Такої країни немає в нашому словнику");
                    return false;
                }
                // Якщо ж є у словнику,то виводимо.
                Console.WriteLine("{0}->>>{1}", item, dict[item]);//.TryGetValue(country,)[country]) ;
            }
            else
            {
                // Тут навпаки,вже питаємо,чи є такий value у словнику.
                if (dict.ContainsValue(item) == false)
                {
                    Console.WriteLine("Такої столиці немає в нашому словнику");
                    return false;
                }
                Console.WriteLine("{0}->>>{1}", item, dict.First(x => x.Value == item).Key);//ElementAtOrDefault(country);//.SingleOrDefault(x => x.Value == country).Key) ;//.FirstOrDefault(x => x.Value == country).Key);
            }
            return true;

        }

        public void ShowDictionary(Dictionary<string,string>dict)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("* Вітаємо!Це словник назв країн світу! *");
            Console.WriteLine("****************************************");

            foreach(KeyValuePair<string,string> el in dict)
            {
                Console.WriteLine(" {0,10}     {1,5}", el.Key, el.Value);
            }
           
        }

    }
}
