using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_OOP_Opdracht
{
    class Dice
    {
        public int Sides { get; set; } //set is niet slim
        public List<int> nmbrsTimeThrown = new List<int>(); //als niet in klassendiagram staat moet het private zijn

        public int Throw() 
        {
           Random rd = new Random();
           int randomNummer = rd.Next(1, Sides + 1); 
           nmbrsTimeThrown.Add(randomNummer);
           return randomNummer; //geen afkortingen gebruik camelcase of pascalcase
        }

        public void ResetStatistics() 
        {
            nmbrsTimeThrown.Clear();   
        }

        public int CheckNmbrsTimeThrown(int valueToFind) //verkeerde naam pak zelfde als klassendiagram
        {
            //for loop maken
            //return ((from temp in nmbrsTimeThrown where temp.Equals(valueToFind) select temp).Count());
        }

    }
}
