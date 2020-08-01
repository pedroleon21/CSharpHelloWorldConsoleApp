using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldAppConsole
{
    public class Mundo
    {
        public int Num { get; set; }
        public string Resposta { set; get; }
        public Mundo ()
        { }
        public Mundo(string resposta)
        {
            Resposta = resposta;
        }
        public Mundo(string resposta, int num)
        {
            Resposta = resposta;
            Num = num;
        }
        public bool Valido()
        {
            Console.WriteLine($"{this.Resposta.Length} {this.Num}");
            if (Resposta.Length <= 0 || Num == 0)
                return false;
            return true;
        }

    }
}
