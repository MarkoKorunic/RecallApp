using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }


    class Deck
    {
        string Name { get; set; }
        DateTime DateCreated
        {
            get
            {
                return DateTime.Now;
            }
        }
        string CardList { get; set; }


    }

    class Card
    {
        Deck Deck { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
        DateTime DateCreated
        {
            get
            {
                return DateTime.Now;
            }
        }
        
        


    }

}


